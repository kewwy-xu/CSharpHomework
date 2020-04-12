using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Order_Console
{
     public class GenerateOrderNo
    {
        private static readonly object Locker = new object();
        private static int sn = 10;

        public static string GenerateNo()
        {
            lock (Locker)   //lock 关键字可确保当一个线程位于代码的临界区时，另一个线程不会进入该临界区。
            {
                sn++;
                return  sn.ToString().PadLeft(8, '0');
            }
        }
    }
}
