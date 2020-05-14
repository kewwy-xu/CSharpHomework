using Order_Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_Winform
{
    public partial class AddOrderForm : Form
    {
        public Order order { get; set; }
        
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void summit_btn_Click(object sender, EventArgs e)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            for (int i = 0; i < proName_checkedListBox.Items.Count; i++)
            {
                if (proName_checkedListBox.GetItemChecked(i))
                {
                    string pName = proName_checkedListBox.GetItemText(proName_checkedListBox.Items[i]);                                     
                    int pAmount=0;
                    switch (pName)
                    {
                        case "篮球": pAmount = Convert.ToInt32(textBox1.Text); break;
                        case "足球": pAmount = Convert.ToInt32(textBox2.Text); break;
                        case "乒乓球": pAmount = Convert.ToInt32(textBox3.Text); break;
                        case "排球": pAmount = Convert.ToInt32(textBox4.Text); break;
                        case "羽毛球": pAmount = Convert.ToInt32(textBox5.Text); break;
                        case "棒球": pAmount = Convert.ToInt32(textBox6.Text); break;
                        case "网球": pAmount = Convert.ToInt32(textBox7.Text); break;
                    }
                    OrderItem orderItem = new OrderItem( pName,  pAmount);
                    orderItem.OrderId = orderNo_tbox.Text;
                    orderItems.Add(orderItem);                   
                }
            }
            if(orderNo_tbox.Text==null)
                MessageBox.Show("请填写订单号！");
            else
            {
                order = new Order(orderNo_tbox.Text,
                DateTime.Now, cusNameInput_tbox.Text, orderItems);
                MainForm.orderService.AddOrder(order);
                MessageBox.Show("添加成功！");
            }
                    

        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
