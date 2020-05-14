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
    public partial class DeleteOrderForm : Form
    {
        public DeleteOrderForm()
        {
            InitializeComponent();
        }

        private void agree_btn_Click(object sender, EventArgs e)
        {
            //更新到数据库
            using (var context = new OrderContext())
            {
                var order = context.Orders.Include(b => b.orderItems)
                    .FirstOrDefault(p => p.orderNo == deleteInput_tbox.Text);
                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                    MessageBox.Show("删除成功！");
                }
            }
        }
    }
}
