using System;

namespace Homework4_2
{
    public delegate void ClockAlarm(object sender);  //声明委托
    public class Clock
    {
        public event ClockAlarm Alarm;   //定义响铃事件，相当于创建一个委托实例
        public void SetClock(string h,string m,string s)   //设置响铃时间
        {
            while (true)
            {
                //打印当前时间
                Console.WriteLine(DateTime.Now.ToLongTimeString().ToString());   
                System.Threading.Thread.Sleep(1000);

                //判断当前时间是否等于响铃时间
                if (h == DateTime.Now.Hour.ToString() && m == DateTime.Now.Minute.ToString()
                    && s == DateTime.Now.Second.ToString())
                {
                    Alarm(this);    //触发响铃事件
                }
            }
        }
    }
    public class RunClock
    {
        public Clock clock = new Clock();
        //为Alarm事件添加一个处理方法;响铃CAlarm()
        public RunClock()
        {
            clock.Alarm += CAlarm;
        }     
        public void CAlarm(object sender)
        {
            while(true)
            {
                Console.WriteLine("叮叮叮-------------------叮叮叮");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RunClock runClock =new RunClock();
            runClock.clock.SetClock("15","37","45");
        }
    }
}
