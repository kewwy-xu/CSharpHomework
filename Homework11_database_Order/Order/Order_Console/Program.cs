using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Order_Console
{
    [Serializable]
    public class Order
    {
        [Key]
        public string orderNo { get; set; }
        public DateTime orderTime {get; set; }
        public string customerName { get; set; }
        public List<OrderItem> orderItems { get; set; }
        public float orderSum     //订单总金额
        {
            get
            {               
                try
                {
                    float sum = 0;
                    foreach (OrderItem oi in orderItems)
                    {
                        sum += oi.productSum;
                    }
                    return sum;
                }
                catch (NullReferenceException) { return 0; }                
            }
            set { }
        }

        public Order() { }        

        public Order(string orderNo, DateTime orderTime, 
            string customerName, List<OrderItem> orderItems)
        {
            this.orderNo = orderNo;
            this.orderTime = orderTime;
            this.customerName = customerName;
            this.orderItems = orderItems;
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   orderNo == order.orderNo;
        }

        public override string ToString()
        {
            Console.WriteLine("No:" + orderNo + "  Time:" + orderTime +
                "  Customer:" + customerName + "  sum:" + orderSum);
            foreach (OrderItem item in orderItems)
            {
                Console.WriteLine(item.ToString());
            }
            return "";
        }
    }


    [Serializable]
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }   //主键      
        public string OrderId { get; set; }   //外键

        public string productNo
        {
            get
            {
                try { return ProductInfo.NameNoDic[productName]; }
                catch (ArgumentNullException) { return ""; }
            }
            set { }
        }
        public string productName { get; set; }
        public float productPrice
        {
            get
            {
                try { return ProductInfo.NamePriceDic[productName]; }
                catch (ArgumentNullException) { return 0; }
            }
            set { }
        }
        public int productAmount { get; set; }     //产品数量
        public float productSum { get { return productPrice * productAmount; } set { } }
        
        
        public OrderItem() { }
        public OrderItem( string productName, int productAmount)
        {           
            this.productName = productName;         
            this.productAmount = productAmount;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderItem item &&
                   productNo == item.productNo;
        }


        public override string ToString()
        {

            return (productNo + "  " + productName + "  price:" +
                productPrice + "  amount:" + productAmount + "  sum:" + productSum);
        }     
    }

    [Serializable]
    public class OrderService
    {
        public List<Order> orderList = new List<Order>();

        public OrderService(List<Order> orderList)
        {
            this.orderList = orderList;
        }

        //按照订单号排序
        void Sort1()
        {

            orderList.Sort((p1, p2) => Convert.ToInt32(p1.orderNo)- Convert.ToInt32(p2.orderNo));
        }

        //添加订单
        public void AddOrder(Order order)
        {
            if(orderList.Contains(order))
            {
                Console.WriteLine("订单号重复！");
                return;
            }                         
            orderList.Add(order);
            Console.WriteLine("添加订单成功!");
            Sort1();

            //添加到数据库
            using (var context = new OrderContext())
            {
                context.Orders.Add(order);
                foreach (var oi in order.orderItems)
                    context.OrderItems.Add(oi);
                context.SaveChanges();
            }
        }
        //删除订单
        public void DeleteOrder(string orderNo)
        {
            try
            {
                int i;
                for (i = 0; i < orderList.Count; i++)
                {
                    if (orderNo == orderList[i].orderNo)
                        break;
                }
                if (i == orderList.Count)
                    throw new Exception("该订单不存在，无法删除！");
                orderList.Remove(orderList[i]);
                Console.WriteLine("删除订单成功!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //修改订单,输入新的订单
        public void ChangeOrder(Order order)
        {
            try
            {
                int i;
                for (i = 0; i < orderList.Count; i++)
                {
                    if (order.orderNo == orderList[i].orderNo)
                        break;
                }
                if (i == orderList.Count)
                    throw new Exception("该订单不存在，无法修改！");
                orderList.Remove(orderList[i]);
                orderList.Add(order);
                Sort1();
                Console.WriteLine("修改订单成功！");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //按订单号查询某订单
        public bool FindOrder(string orderNo)
        {
            
            var query = orderList.Where(ol => ol.orderNo == orderNo);
            if (query.Count(x => true) == 0)
            {
                Console.WriteLine("该订单不存在！");
                Console.WriteLine();
                return false;
            }
            foreach (var o in query)
            {
                Console.WriteLine("查询订单号为" + orderNo + "的订单：");
                Console.WriteLine(o.ToString());
                Console.WriteLine();
            }
                     
            return true;
        }

        //查询所有订单，查询结果按照订单总金额降序返回
        public bool FindAllOrders()
        {
            var query = orderList.OrderByDescending(ol => ol.orderSum);
            if (query.Count(x => true) != orderList.Count)
                return false;
            foreach (var o in query)
            {
                Console.WriteLine();
                o.ToString();
                Console.WriteLine();
            }
            return true;
        }

        //将所有的订单序列化为XML文件
        public void ExportAllOrders(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                xmlSerializer.Serialize(fs, orderList);
            }

            Console.WriteLine("\nSerialized as XML:");
            Console.WriteLine(File.ReadAllText(fileName));
        }

        //从XML文件里反序列化,载入订单
        public void ImportOrders(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                List<Order> orderList1 = (List<Order>)xmlSerializer.Deserialize(fs);
                
                Console.WriteLine("\nDeserialized from orders.xml");
                foreach (Order o in orderList1)
                {
                    orderList.Add(o);
                    Console.WriteLine(o);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<OrderItem> orderItems1 = new List<OrderItem>()
            {  new OrderItem( "篮球",  3),
               new OrderItem("足球",2),
               new OrderItem("排球",5),
            };
            List<OrderItem> orderItems2 = new List<OrderItem>()
            {
               new OrderItem("足球",1),
               new OrderItem("乒乓球",10)
            };
            List<OrderItem> orderItems3 = new List<OrderItem>()
            {
                new OrderItem("羽毛球",3)
            };

            orderItems1.Add(new OrderItem( "网球",  1));

            List<Order> orderList = new List<Order>()
            {
                new Order("00000004",new DateTime(2020,3,21,14,20,00),"张三",orderItems1),
                new Order("00000005",new DateTime(2020,3,20,9,50,00),"李四",orderItems2)
            };
            OrderService orderService = new OrderService(orderList);

            orderService.AddOrder(new Order("00000004", new DateTime(2020, 3, 10, 10, 40, 33),
                "王五", orderItems3));
            orderService.FindAllOrders();

            orderService.AddOrder(new Order("00000006", new DateTime(2020, 3, 10, 10, 40, 33),
                "王五", orderItems3));
            orderService.FindAllOrders();

            orderService.DeleteOrder("00000001");
            orderService.FindAllOrders();

            orderItems2.Add(new OrderItem( "棒球",  7));
            orderItems2.Remove(new OrderItem( "足球",  1));
            orderService.ChangeOrder(new Order("00000005", new DateTime(2020, 3, 11, 16, 21, 11),
                "李四", orderItems2));
            orderService.FindAllOrders();

            orderService.FindOrder("00000008");    //不存在订单情况
            orderService.FindOrder("00000004");    //存在订单情况

            orderService.ExportAllOrders("orders.xml");

            orderService.ImportOrders("orders.xml");

            Console.ReadKey();
        }
    }
}
