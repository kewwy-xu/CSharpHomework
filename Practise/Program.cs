using System;

namespace Practise
{
    class Program
    {
        //-------------------1.编写程序输出用户指定数据的所有素数因子-----------------
        public void IsPrimeNumber(int num)   //判断一个数是否为素数，若是素数则输出
        {
            bool flag = true;
            for (int i = 2; i*i <= num; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
                Console.WriteLine(num);
            else
                return;
        }
        public void Output(int num)    //输出用户指定数据的所有素数因子
        {
            for (int i = 2; i*i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (i * i != num)
                    {
                        IsPrimeNumber(i);
                        IsPrimeNumber(num / i);
                    }
                    else
                        IsPrimeNumber(i);
                }
            }
        }
        //--------------2.编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和-----------
       
        public void ArrayOp(int []array)    
        {
            int maxValue = array[0];
            int minValue = array[0];
            int i = 1; 
            while(i<array.Length)        //求最大值
            {
                if (maxValue < array[i])
                    maxValue = array[i];
                i++;
            }
            i = 1;
            while (i < array.Length)     //求最小值
            {
                if (minValue > array[i])
                    minValue = array[i];
                i++;
            }
            int sum = 0;i = 0;
            while (i < array.Length)
                sum += array[i++];
            double avg = sum / array.Length;

            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
            Console.WriteLine(avg);
            Console.WriteLine(sum);
        }


        //----------------------------3.用“埃氏筛法”求n以内的素数-------------------
        public void Choose(int n)
        {
            bool []isPrime=new bool[n+1];
            int[] prime=new int[n];      //prime[]数组存放n以内的素数
            int k = 0;
            for (int i = 2; i <= n; i++)
                isPrime[i] = true;
            isPrime[0] = isPrime[1] = false;
            for (int i = 2; i<= n; i++)
            {
                if (isPrime[i])
                {
                    prime[k++] = i;
                    for (int j = 2 * i; j <= n; j += i)
                        isPrime[j] = false;
                }
            }
            for(int i=0;i<k;i++)            //输出
                Console.WriteLine(prime[i]);
        }

        //----------------------------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {          
            Program test = new Program();

            //第二题
            int[] array = { 12, 54, 6, 23, 76, 11, 53, 97, 111, 483, 2929, 433, 323, 687 };
            test.ArrayOp(array);


            //第一题
            Console.Write("请输入一个正整数：");
            int num1 = Convert.ToInt32(Console.ReadLine());
            test.Output(num1);


            //第三题
            Console.Write("请输入一个正整数：");
            int num2 = Convert.ToInt32(Console.ReadLine());
            test.Choose(num2);

        }
    }
}
