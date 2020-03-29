using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework_5;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        public List<Order> ReturnOrderList()
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
            
            List<Order> orderList = new List<Order>()
            {
                new Order(001,new DateTime(2020,3,21,14,20,00),"徐先生",orderItems1),
                new Order(002,new DateTime(2020,3,20,9,50,00),"刘女士",orderItems2)
            };
            return orderList;
        }
                 
        [TestMethod()]                 //正常情况
        public void AddOrderTest1()
        {
            List<OrderItem> orderItems3 = new List<OrderItem>()
            {
                new OrderItem(206,"牙刷",4f,3)
            };

            OrderService orderService = new OrderService(ReturnOrderList());
            orderService.AddOrder(new Order(003, new DateTime(2020, 3, 10, 10, 40, 33),
                "赵先生", orderItems3));
           
            Assert.AreEqual(3, orderService.orderList.Count);
        }

        [TestMethod()]                   //订单已存在情况
        public void AddOrderTest2()
        {
            List<OrderItem> orderItems3 = new List<OrderItem>()
            {
                new OrderItem(206,"牙刷",4f,3)
            };

            OrderService orderService = new OrderService(ReturnOrderList());
            orderService.AddOrder(new Order(002, new DateTime(2020, 3, 10, 10, 40, 33),
                "赵先生", orderItems3));

            Assert.AreEqual(2, orderService.orderList.Count);
        }


        [TestMethod()]           //正常情况
        public void DeleteOrderTest1()
        {
            OrderService orderService = new OrderService(ReturnOrderList());
            orderService.DeleteOrder(001);

            Assert.AreEqual(1, orderService.orderList.Count);
        }

        [TestMethod()]        //订单不存在情况
        public void DeleteOrderTest2()
        {
            OrderService orderService = new OrderService(ReturnOrderList());
            orderService.DeleteOrder(003);
        }


        [TestMethod()]         //正常情况
        public void ChangeOrderTest1()
        {
            List<OrderItem> orderItems2 = new List<OrderItem>()
            {
               new OrderItem(202,"足球",36f,1),
               new OrderItem(205,"乒乓球",5.7f,10)
            };
            OrderService orderService = new OrderService(ReturnOrderList());
            //以修改订单用户名字为例
            Order oldOrder = new Order(002, new DateTime(2020, 3, 20, 9, 50, 00), 
                "刘女士", orderItems2);
            Order newOrder = new Order(002, new DateTime(2020, 3, 11, 16, 21, 11),
               "李女士", orderItems2);
            orderService.ChangeOrder(newOrder);

            Assert.AreEqual("李女士",orderService.orderList[1].customerName);
        }

        [TestMethod()]         //订单不存在，无法修改情况
        public void ChangeOrderTest2()
        {
            List<OrderItem> orderItems2 = new List<OrderItem>()
            {
               new OrderItem(202,"足球",36f,1),
               new OrderItem(205,"乒乓球",5.7f,10)
            };
            OrderService orderService = new OrderService(ReturnOrderList());
            Order newOrder = new Order(003, new DateTime(2020, 3, 11, 16, 21, 11),
               "李女士", orderItems2);
            orderService.ChangeOrder(newOrder);
        }

        [TestMethod()]     //正常情况
        public void FindOrderTest1()
        {
            OrderService orderService = new OrderService(ReturnOrderList());
            Assert.IsTrue(orderService.FindOrder(001));
        }

        [TestMethod()]     //订单不存在，无法查找情况
        public void FindOrderTest2()
        {
            OrderService orderService = new OrderService(ReturnOrderList());
            Assert.IsFalse(orderService.FindOrder(003));
        }

        [TestMethod()]       //订单表不为空的情况
        public void FindAllOrdersTest1()
        {
            OrderService orderService = new OrderService(ReturnOrderList());
            Assert.IsTrue(orderService.FindAllOrders());
        }

        [TestMethod()]     //订单表为空的情况
        public void FindAllOrdersTest2()
        {
            List<Order> orderList = new List<Order>();
            OrderService orderService = new OrderService(orderList);
            Assert.IsTrue(orderService.FindAllOrders());
        }

        //Export()和Import()方法不知道如何测试，我认为直接通过命令行运行结果观察更加方便
        [TestMethod()]
        public void ExportAllOrdersTest()
        {
                       
        }

        [TestMethod()]
        public void ImportOrderTest()
        {
           
        }
    }
}