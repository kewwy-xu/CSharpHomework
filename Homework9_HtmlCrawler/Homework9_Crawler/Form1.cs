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
using Homework9_console;
namespace Homework9_Crawler
{
    public partial class Form1 : Form
    {
        public SimpleCrawler myCrawler = new SimpleCrawler();
        public Form1()
        {
            InitializeComponent();
            try
            {
                textBox1.DataBindings.Add("Text", myCrawler, "startUrl");
            }catch(ArgumentNullException) { }
        }
              
        private void button1_Click(object sender, EventArgs e)
        {
            myCrawler.urls.Add(myCrawler.startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }
    }
}
