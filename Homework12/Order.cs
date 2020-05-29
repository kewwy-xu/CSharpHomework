using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Homework12
{
    public class Order
    {
        [Key]
        public string orderNo { get; set; }
        public DateTime orderTime { get; set; }
        public string customerName { get; set; }
        public List<OrderItem> orderItems { get; set; }
        
        public float orderSum { get; set; }   //订单总金额
       

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

    public class OrderItem
    {
        public int OrderItemId { get; set; }   //主键      
        public string OrderId { get; set; }   //外键
        public string productNo { get; set; }
        public string productName { get; set; }
        public float productPrice { get; set; }
      
        public int productAmount { get; set; }     //产品数量
        public float productSum { get; set; }


        public OrderItem() { }
        public OrderItem(string productName, int productAmount)
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
}
