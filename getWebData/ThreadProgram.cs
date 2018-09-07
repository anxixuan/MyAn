using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace getWebData
{
    class ThreadProgram
    {
        static void Main1(string[] a)
        {
            #region 1、线程的使用
            //Thread t1 = new Thread(new ThreadStart(TestMethod1));
            //Thread t2 = new Thread(new ParameterizedThreadStart(TestMethod));
            //t1.IsBackground = true;
            //t2.IsBackground = true;
            //t1.Start();
            //t2.Start("12452"); 
            #endregion

            #region 2、线程池
            //ThreadPool.QueueUserWorkItem(TestMethod,"这是第一次使用线程池");
            //ThreadPool.QueueUserWorkItem(TestMethod,"123");
            #endregion

            #region 3、Task;2简单，但是最大问题该方法最大的问题是没有一个内建的机制让你知道操作什么时候完成
            //Task<Int32> t = new Task<Int32>(n => Sum((Int32)n), 100000);
            //t.Start();
            //t.Wait();
            //Console.WriteLine(t.Result);
            //Task<Int32> t = new Task<Int32>(n => Sum((Int32)n), 1000);
            //t.Start();
            //Task cwt = t.ContinueWith(n => Console.WriteLine($"The result is {t.Result}"));
            #endregion



            Console.ReadKey();
        }
        #region 1、线程的使用
        /// <summary>
        /// 不带参数
        /// </summary>
        public static void TestMethod1()
        {
            Console.WriteLine("不带参数的线程函数");
        }
        /// <summary>
        /// 带参数
        /// </summary>
        /// <param name="data">string</param>
        public static void TestMethod(object data)
        {
            string str = data as string;

            Console.WriteLine($"带参数的，参数是{str}");
        }
        #endregion

        #region 3、Task使用
        public static Int32 Sum(Int32 n)
        {
            Int32 sum = 0;
            for(;n>0;--n)
                checked { sum += n; }
            return sum;
        }
        #endregion
    }
}
