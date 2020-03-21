using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework5
{
    public class Order
    {
        public int orderNo;
        public DateTime orderTime;
        public string customerName;
        public List<OrderItem> orderItems;

        public Order(int orderNo, DateTime orderTime,
            string customerName, List<OrderItem> orderItems)
        {
            this.orderNo = orderNo;
            this.orderTime = orderTime;
            this.customerName = customerName;         
            this.orderItems = orderItems;
        }

        public float OrderSum()
        {
            float sum = 0;
            foreach(OrderItem oi in orderItems)
            {
                sum += oi.productPrice * oi.productAmount;
            }
            return sum;
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   orderNo == order.orderNo;
        }

        public override string ToString()
        {
            Console.WriteLine("No:" + orderNo + "  Time:" + orderTime +
                "  Customer:" + customerName + "  sum:" + OrderSum());
            foreach (OrderItem item in orderItems)
            {
                item.ToString(); 
            }
            return "";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(orderNo);
        }
    }

    public class OrderItem
    {
        public int productNo;
        public string productName;
        public float productPrice;
        public int productAmount;

        public OrderItem(int productNo, string productName, float productPrice,
            int productAmount)
        {
            this.productNo = productNo;
            this.productName = productName;
            this.productPrice = productPrice;
            this.productAmount = productAmount;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderItem item &&
                   productNo == item.productNo;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(productNo);
        }

        public override string ToString()
        {
            Console.WriteLine();
            return (productNo + "  " + productName + "  price:" +
                productPrice + "  amount:" + productAmount + "  sum:" + productPrice*productAmount);
        }
    }

    public class OrderService
    { 
        List<Order> orderList = new List<Order>();

        public OrderService(List<Order> orderList)
        {
            this.orderList = orderList;
        }

        //按照订单号排序
        public void Sort1()
        {
            orderList.Sort((p1,p2)=>p1.orderNo-p2.orderNo);
        }

        //添加订单
        public void AddOrder(Order order)
        {
            for (int i = 0; i < orderList.Count; i++)
            {
                if (order.Equals(orderList[i]))
                {
                    Console.WriteLine("订单号重复！");
                    return;
                }
            }
            orderList.Add(order);
            Console.WriteLine("添加订单成功!");
            Sort1();
        }
        //删除订单
        public void DeleteOrder(int orderNo)
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
                Sort1();
                Console.WriteLine("删除订单成功!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }            
        }

        //修改订单
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
        public void FindOrder(int orderNo)
        {
            var query = orderList.Where(ol => ol.orderNo == orderNo);
            foreach(var o in query)
            {
                if (o == null)
                    Console.WriteLine("该订单不存在！");
                else
                    Console.WriteLine(o.ToString());
            }              
        }

        //查询所有订单，查询结果按照订单总金额降序返回
        public void FindAllOrders()
        {
            var query = orderList.OrderBy(ol => ol.OrderSum()); 
            foreach(var o in query)
            {
                Console.WriteLine();
                Console.WriteLine();
                o.ToString();
            }
        }
    }


     class Program
    {       
        static void Main(string[] args)
        {
            List<OrderItem> orderItems1 = new List<OrderItem>()
            {  new OrderItem(201, "篮球", 50.5f, 3),
               new OrderItem(202,"足球",36f,2),
               new OrderItem(203,"排球",40f,5),
            };
            List<OrderItem> orderItems2 = new List<OrderItem>()
            {
               new OrderItem(202,"足球",36f,1),
               new OrderItem(205,"乒乓球",5.7f,10)
            };
            List<OrderItem> orderItems3 = new List<OrderItem>()
            {
                new OrderItem(206,"牙刷",4f,3)
            };

            orderItems1.Add(new OrderItem(204, "网球", 20.2f, 1));

            List<Order> orderList = new List<Order>()
            {
                new Order(001,new DateTime(2020,3,21,14,20,00),"徐先生",orderItems1),
                new Order(002,new DateTime(2020,3,20,9,50,00),"刘女士",orderItems2)
            };
            OrderService orderService = new OrderService(orderList);

            orderService.AddOrder(new Order(002, new DateTime(2020, 3, 10, 10, 40, 33),
                "赵先生", orderItems3));
            orderService.FindAllOrders();

            orderService.AddOrder(new Order(003, new DateTime(2020, 3, 10, 10, 40, 33),
                "赵先生", orderItems3));
            orderService.FindAllOrders();

            orderService.DeleteOrder(001);
            orderService.FindAllOrders();

            orderItems2.Add(new OrderItem(211, "牙膏", 6.22f, 7));
            orderItems2.Remove(new OrderItem(202, "足球", 36f, 1));
            orderService.ChangeOrder(new Order(002, new DateTime(2020, 3, 11, 16, 21, 11),
                "李女士", orderItems2));
            orderService.FindAllOrders();

            orderService.FindOrder(002);
        }
    }
}
