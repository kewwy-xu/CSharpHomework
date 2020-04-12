using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Console
{
    public class ProductInfo
    {
        public static Dictionary<string, string> NameNoDic
        {
            get{
                Dictionary<string, string> nameNoDic = new Dictionary<string, string>
                {
                    { "篮球", "001" },
                    { "足球", "002" },
                    { "乒乓球", "003" },
                    { "排球", "004" },
                    { "羽毛球", "005" },
                    { "棒球", "006" },
                    { "网球", "007" }
                };
                return nameNoDic;
            }
        }
        public static Dictionary<string, float> NamePriceDic
        {
            get
            {
                Dictionary<string, float> namePriceDic = new Dictionary<string, float>
                {
                    { "篮球", 200 },
                    { "足球", 145 },
                    { "乒乓球", 5 },
                    { "排球", 123.5f },
                    { "羽毛球", 3.99f },
                    { "棒球", 86 },
                    { "网球", 98.3f }
                };
                return namePriceDic;
            }
        }
    }
}
