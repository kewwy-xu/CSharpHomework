using Order_Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            orderService.AddOrder(new Order("00000001", new DateTime(2020, 3, 21, 14, 20, 00), "徐先生", orderItems1));
            orderService.AddOrder(new Order("00000002", new DateTime(2020, 3, 20, 9, 50, 00), "刘女士", orderItems2));                   

            order_bindingSource.DataSource = orderService.orderList;
           
            queryInput_textbox.DataBindings.Add("Text", this, "KeyWord");
        }

        //按订单号查询
        private void queryByCustomerName_btn_Click(object sender, EventArgs e)
        {
            if (KeyWord == null || KeyWord == "")
            {
                order_bindingSource.DataSource = orderList;
            }
            else
            {
                order_bindingSource.DataSource =
                    orderList.Where(s => s.customerName == KeyWord);
            }
        }

        //按客户名查询
        private void queryByOrderNo_btn_Click(object sender, EventArgs e)
        {
            if (KeyWord == null || KeyWord == "")
            {
                order_bindingSource.DataSource = orderList;
            }
            else
            {
                order_bindingSource.DataSource =
                   orderList.Where(s => s.orderNo == KeyWord);
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach(Order o in orderList)
            {
                Console.WriteLine(o.orderNo);
            }
        }
    }
}
