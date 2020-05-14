using Order_Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_Winform
{
    public partial class MainForm : Form
    {
        public string KeyWord { get; set; }
        public static List<Order> orderList = new List<Order>();
        public static OrderService orderService = new OrderService(orderList);
        public MainForm()
        {
            InitializeComponent();
            /*
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

            orderService.AddOrder(new Order("81", new DateTime(2020, 3, 21, 14, 20, 00), "aaa", orderItems1));
            orderService.AddOrder(new Order("82", new DateTime(2020, 3, 20, 9, 50, 00), "刘女士", orderItems2));                   
          */
            order_bindingSource.DataSource = orderService.orderList;
           
            queryInput_textbox.DataBindings.Add("Text", this, "KeyWord");
        }

        //按订单号查询
        private void queryByOrderNo_btn_Click(object sender, EventArgs e)
        {              
            using (var context = new OrderContext())
            {
                if (KeyWord == null || KeyWord == "")
                {
                    List<Order> list = new List<Order>();
                    foreach (var o in context.Orders)
                        list.Add(o);
                    order_bindingSource.DataSource = list;

                    List<OrderItem> list1 = new List<OrderItem>();
                    foreach (var oi in context.OrderItems)
                    {
                        list1.Add(oi);
                    }
                    orderItem_bindingSource.DataSource = list1;
                }
                else
                {
                    order_bindingSource.DataSource =
                        context.Orders.FirstOrDefault(p => p.orderNo == KeyWord);

                    List<OrderItem> list1 = new List<OrderItem>();
                    foreach (var oi in context.OrderItems)
                    {
                        if(oi.OrderId==KeyWord)
                            list1.Add(oi);
                    }
                    orderItem_bindingSource.DataSource = list1;
                }                             
            }
        }
        
        //按客户名查询
        private void queryByCustomerName_btn_Click(object sender, EventArgs e)
        {
            using (var context = new OrderContext())
            {
                if (KeyWord == null || KeyWord == "")
                {
                    List<Order> list = new List<Order>();
                    foreach (var o in context.Orders)
                        list.Add(o);
                    order_bindingSource.DataSource = list;

                    List<OrderItem> list1 = new List<OrderItem>();
                    foreach (var oi in context.OrderItems)
                    {
                        list1.Add(oi);
                    }
                    orderItem_bindingSource.DataSource = list1;
                }
                else
                {
                    var order = context.Orders.FirstOrDefault(p => p.customerName == KeyWord);
                    order_bindingSource.DataSource = order;
                        
                    List<OrderItem> list1 = new List<OrderItem>();
                    foreach (var oi in context.OrderItems)
                    {
                        if (oi.OrderId == order.orderNo)
                            list1.Add(oi);
                    }
                    orderItem_bindingSource.DataSource = list1;
                }
            }
        }

        //添加订单
        private void addOrder_btn_Click(object sender, EventArgs e)
        {
            AddOrderForm add = new AddOrderForm();   
            add.ShowDialog();
        }

        //导入订单
        private void importOrder_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                orderService.ImportOrders(openFileDialog1.FileName);
            }
        }

        //导出订单
        private void exportOrder_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                orderService.ExportAllOrders(openFileDialog1.FileName);
            }           
        }
        
        //删除订单
        private void delete_btn_Click(object sender, EventArgs e)
        {
            DeleteOrderForm d = new DeleteOrderForm();
            d.ShowDialog();
        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}

