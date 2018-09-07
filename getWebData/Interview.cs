using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getWebData
{
    public class Interview
    {
        static void Main1(string[] args)
        {
            #region 面试问题
            //List<foo> fooList = new List<foo> {
            //    new foo { Id=1,Name="b"},
            //    new foo { Id=2,Name="a"},
            //    new foo { Id=3,Name="A"},
            //    new foo { Id=4,Name="B"}
            //};
            //t5(fooList);
            //var tem = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////Dictionary<int, string> dic = tem.ToDictionary(t => t, t => (t * 2).ToString());
            ////foreach (var v in dic)
            ////{
            ////    Console.WriteLine(v);
            ////}
            //HashSet<int> hs = new HashSet<int>(tem);
            ////Console.WriteLine(hs.FirstOrDefault(h=>h==20));

            //List<int> array = new List<int>(tem);
            ////Console.WriteLine(array.Find(a=>a==20));

            //LinkedList<int> link = new LinkedList<int>(tem);
            //var f1 = link.Find(3);
            //link.Remove(f1);
            //Console.WriteLine(link.Where(t=>t%2!=0).Sum());
            //float t = 1.23f;
            //Console.WriteLine(t==1.23?"相等":"不相等");

            //string s = "abc";
            //Console.WriteLine(s[2]=='c'? "相等" : "不相等");

            //uint i = 0xffffffff;
            int j = 0;
            //int? k = j as int?;
            //Console.WriteLine(k.HasValue?k.Value.ToString():"null");
            //Console.WriteLine(j+1);

            Console.WriteLine(typeof(int));

            string s = $"ads ads {j}";

            Console.WriteLine(s);
            #endregion

            Console.ReadKey();
        }
        #region 面试问题
        static void t1(List<foo> li)
        {
            var ns = li.OrderBy(f => f.Id).ToList();
            ns.ForEach(f => Console.Write(f.ToString() + "\r\n"));
        }
        static void t2(List<foo> li)
        {
            var ns = li.OrderBy(f => f.Name).ToList();
            ns.ForEach(f => Console.Write(f.ToString() + "\r\n"));
        }
        static void t3(List<foo> li)
        {
            var ns = li.OrderBy(f => f.Name).Select(f => f.Id).ToList();
            ns.ForEach(f => Console.Write(f.ToString() + "\r\n"));
        }
        static void t4(List<foo> li)
        {
            var ns = li.OrderBy(f => f.Name).Select(f => f.Name).ToList();
            ns.ForEach(f => Console.Write(f.ToString() + "\r\n"));
        }
        static void t5(List<foo> li)
        {
            var ns = li.OrderBy(f => f.Name, StringComparer.Ordinal).Select(f => f.Name).ToList();
            ns.ForEach(f => Console.Write(f.ToString() + "\r\n"));
        }
        #endregion
    }
    class foo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return string.Format("Id:{0},Name={1}", Id, Name);
        }
    }
}
