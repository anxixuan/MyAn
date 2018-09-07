using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using FluentScheduler;
using System.Net.Mail;

namespace getWebData
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1、测试
            //string str = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">"
            // + "<html xmlns=\"http://www.w3.org/1999/xhtml\">"
            // + "<head>"
            // + "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"/>"
            // + "<meta content=\"怎样用c 正则表达式解析HTML中a 超链接 址 .NET技术 ASP.NET\" name=\"Keywords\"/>"
            // + "<meta content=\"是用c 正则表达式 是在后台 不是js正则表达式 是要获取a href属性值\" name=\"description\"/>"
            // + "<title>怎样用c#正则表达式解析HTML中a的超链接地址 - .NET技术 / ASP.NET</title>"
            // + "<li><a href=\"http://news.csdn.net/\" target=\"_blank\">资讯</a>|</li>"
            // + "<li><a href=\"http://mobile.csdn.net/\" target=\"_blank\">移动</a>|</li>"
            // + "<li><a href=\"http://cloud.csdn.net/\" target=\"_blank\">云计算</a>|</li>"
            // + "<link href=\"http://c.csdn.net/bbs/t/5/t5.css\" rel=\"stylesheet\" type=\"text/css\" />"
            // + "<link href=\"http://www.csdn.net/images/favicon.ico\" rel=\"SHORTCUT ICON\" />";
            //string str = @"";
            //Regex reg = new Regex(@"(?is)<a[^>]*?href=(['""\s]?)(?<href>[^'""\s]*)\1[^>]*?>");
            //MatchCollection match = reg.Matches(str);
            //foreach (Match m in match)
            //{
            //    Console.WriteLine(m.Groups["href"].Value + "<br/>");
            //}
            //var a = GetWebContent("http://www.tianqihoubao.com/aqi/beijing-201704.html");

            //SaveTxt(@"F:\a.txt", a);
            //Console.WriteLine("数据读取完毕");
            #endregion

            #region 2、TXT文件转换为切分文件
            //Console.WriteLine("请输入文件名，不含后缀");
            //string Filename = Console.ReadLine();

            //string directory = System.Environment.CurrentDirectory;
            //try
            //{
            //    List<string> liststring = SaveTxtLine(directory + @"\" + Filename + ".txt");
            //    List<int> flag = new List<int>();
            //    for (int i = 0; i < liststring.Count - 1; i++)
            //    {
            //        if (Convert.ToDouble(liststring[i].Split()[0]) >= Convert.ToDouble(liststring[i + 1].Split()[0]))
            //        {
            //            flag.Add(i);
            //        }
            //    }
            //    flag.Add(liststring.Count - 1);
            //    List<string> listStr = new List<string>();
            //    int total, begin;
            //    for (int i = 0; i < flag.Count; i++)
            //    {
            //        if (i <= 1)
            //        {
            //            listStr.Add(liststring[i]);
            //            SaveTxtList(directory + @"\" + (i + 1) + ".txt", listStr);
            //            listStr.Clear();
            //        }
            //        if (i > 1)
            //        {
            //            total = flag[i] - flag[i - 1];
            //            begin = flag[i - 1];
            //            for (int t = 1; t <= total; t++)
            //            {
            //                listStr.Add(liststring[begin + t]);
            //            }
            //            SaveTxtList(directory + @"\" + (i + 1) + ".txt", listStr);
            //            listStr.Clear();
            //        }
            //    }
            //    Console.WriteLine("执行完毕，请看目录" + directory);
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #region 3、base64转图片
            //string d = TXTtoString(@"D:\4.txt");
            //GetHtmlImageUrlList(d);
            //foreach (string a in GetHtmlImageUrlList(d))
            //{
            //    string[] asplit = a.Split(',');
            //    string imgtype = asplit[0].Substring(11, asplit[0].Length - 18);
            //    string filepath = Base64StringToImage(asplit[1], imgtype);
            //    d = d.Replace(a, filepath);
            //}
            #endregion

            #region 4、获取北京PM指
            //string city = "shenzhen";
            //var d = GetWebContent("http://www.tianqihoubao.com/aqi/" + city + "-201710.html");
            //HtmlDocument doc = new HtmlDocument();
            //doc.LoadHtml(d);
            //TestContext db = new TestContext();

            //int i = 0;
            //foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table"))
            //{
            //    foreach (HtmlNode row in table.SelectNodes("tr"))
            //    {

            //        GetTable ne = new GetTable();
            //        ne.City = city;
            //        if (i != 0)
            //        {

            //            for (int t = 0; t < row.SelectNodes("tr|td").Count; t++)
            //            {
            //                var count = row.SelectNodes("tr|td").Count;
            //                HtmlNode ce = null;
            //                ce = row.SelectNodes("tr|td")[t];
            //                var ff = ce.InnerText.Trim();
            //                if (t == 0)
            //                {
            //                    ne.Date = Convert.ToDateTime(ce.InnerText.Trim());
            //                }
            //                if (t == 1)
            //                    ne.QualityRank = ce.InnerText.Trim();
            //                if (t == 2)
            //                    ne.AQI = Convert.ToInt32(ce.InnerText.Trim());
            //                if (t == 3)
            //                    ne.AQIDateRank = Convert.ToInt32(ce.InnerText.Trim());
            //                if (t == 4)
            //                    ne.PM2 = Convert.ToInt32(ce.InnerText.Trim());
            //                if (t == 5)
            //                    ne.PM10 = Convert.ToInt32(ce.InnerText.Trim());
            //                if (t == 6)
            //                    ne.So2 = Convert.ToInt32(ce.InnerText.Trim());
            //                if (t == 7)
            //                    ne.No2 = Convert.ToInt32(ff);
            //                if (t == 8)
            //                    ne.Co = Convert.ToDouble(ff);
            //                if (t == 9)
            //                    ne.O3 = Convert.ToInt32(ff);
            //            }
            //            db.GetTable.Add(ne);
            //            db.SaveChanges();
            //        }

            //        i = i + 1;

            //    }
            //}
            //Console.WriteLine("完成");
            #endregion

            #region 5、天数
            //DateTime d = new DateTime(2018, 7, 3);

            //Console.WriteLine(d.AddDays(1 - d.Day));
            //Console.WriteLine(d.AddDays(1 - d.Day).AddMonths(1).AddDays(0)); ;
            #endregion

            #region 6、发送邮件
            //SendMail();
            #endregion

            #region 7、Equals 与 == 的关系
            //Person p1 = new Person("aa", 12);
            //Person p2 = p1;

            //Console.WriteLine("p1.Equals(p2)  " + p1.Equals(p2)); 
            #endregion

            Console.WriteLine("OK");
            Console.ReadKey();
        }
        #region 获取网页数据
        /// <summary>
        /// 获取网页数据
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        static private string GetWebContent(string Url)
        {

            string strResult = "";

            #region 第一种不能获取ajax数据
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                //声明一个HttpWebRequest请求 
                request.Timeout = 30000;
                //设置连接超时时间 
                request.Headers.Set("Pragma", "no-cache");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream streamReceive = response.GetResponseStream();
                //gb2312 utf-8
                Encoding encoding = Encoding.GetEncoding("gb2312");
                StreamReader streamReader = new StreamReader(streamReceive, encoding);
                strResult = streamReader.ReadToEnd();
            }
            catch
            {
                Console.Write("出错");
            }
            #endregion

            #region 第二种
            //try
            //{
            //    WebRequest request = WebRequest.Create(Url);
            //    WebResponse response = request.GetResponse();
            //    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
            //    strResult = reader.ReadToEnd();
            //}
            //catch (Exception)
            //{

            //    Console.Write("出错");
            //}
            #endregion
            return strResult;
        } 
        #endregion

        #region 把String数据放到Txt格式文件中
        /// <summary>
        /// 把String数据放到Txt格式文件中
        /// </summary>
        /// <param name="path"></param>
        /// <param name="savaString"></param>
        static  void SaveTxt(string path,string savaString)
        {
            FileStream MyFileStream1 = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(MyFileStream1,Encoding.UTF8);
            sw.WriteLine(savaString);
            //关闭StreamWriter 
            sw.Flush();
            sw.Close();
            //关闭FileStream
            //MyFileStream1.Flush();
            MyFileStream1.Close();
        }
        #endregion

        #region 文本文件一行一行读取，存放到List<string>中
        /// <summary>
        /// 文本文件一行一行读取，存放到List<string>中
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        public static List<string> SaveTxtLine(string FilePath)
        {
            FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(fs, Encoding.Default);
            string strReadline;
            List<string> listStr = new List<string>();
            while ((strReadline = read.ReadLine()) != null)
            {

                listStr.Add(strReadline);

            }
            fs.Close();
            read.Close();
            return listStr;
        }
        #endregion

        #region 把List<String>数据放到Txt格式文件中
        /// <summary>
        /// 把List<String>数据放到Txt格式文件中
        /// </summary>
        /// <param name="path"></param>
        /// <param name="savaString"></param>
        static void SaveTxtList(string FilePath, List<string> listStr)
        {
            
            //foreach (string s in listStr)
            //{
            //    savaString = savaString + s + "\r";
 
            //}
            FileStream MyFileStream1 = new FileStream(FilePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(MyFileStream1, Encoding.UTF8);
         
            foreach (string s in listStr)
            {
                sw.WriteLine(s);
            }
            //关闭StreamWriter 
            sw.Flush();
            sw.Close();
            //关闭FileStream
            //MyFileStream1.Flush();
            MyFileStream1.Close();
        }
        #endregion

        #region 取出<img>中Src的信息
        /// <summary>   
        /// 取得HTML中所有图片的 URL。   
        /// </summary>   
        /// <param name="sHtmlText">HTML代码</param>   
        /// <returns>图片的URL列表</returns>   
        public static string[] GetHtmlImageUrlList(string sHtmlText)
        {
            // 定义正则表达式用来匹配 img 标签   
            //Regex regImg = new Regex(@"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>", RegexOptions.IgnoreCase);
            Regex regImg = new Regex(@"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[''']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n'''<>]*)[^<>]*?/?[\s\t\r\n]*>", RegexOptions.IgnoreCase);

            // 搜索匹配的字符串   
            MatchCollection matches = regImg.Matches(sHtmlText);
            int i = 0;
            string[] sUrlList = new string[matches.Count];

            // 取得匹配项列表   
            foreach (Match match in matches)
                sUrlList[i++] = match.Groups["imgUrl"].Value;
            return sUrlList;
        } 
        
        #endregion

        #region base64转为图片
        private static string Base64StringToImage(string baseString, string fileType)
        {
            try
            {
                byte[] arr = Convert.FromBase64String(baseString);
                MemoryStream ms = new MemoryStream(arr);
                Bitmap bmp = new Bitmap(ms);

                var filename = DateTime.Now.ToString("yyMMddhhmmssff") + "." + fileType;
                //string uploadPath = System.Web.HttpContext.Current.Server.MapPath();
                string uploadPath = System.Environment.CurrentDirectory;
                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }
                FileStream fs1 = new FileStream(uploadPath + "/" + filename, FileMode.Create, FileAccess.Write);//创建写入文件 
                fs1.Close();
                bmp.Save(uploadPath + "/" + filename);
                ms.Close();
                //sr.Close();
                //ifs.Close();
                return "/pic" + "/" + filename ;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

        #region TXT转为string
        /// <summary>
        /// 文件地址包括文件后缀名
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string TXTtoString(string fileName)
        {
            try
            {
                FileStream ifs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(ifs);
                string inputStr = sr.ReadToEnd();
                sr.Close();
                ifs.Close();
                return inputStr;
            }
            catch (Exception ex) { return ex.Message; }
        }

        #endregion

        #region 中奖概率问题

        public static string WinningProbability()
        {
            Random d = new Random();
            var dd=d.Next(1, 3);
            Thread.Sleep(10);
            return dd.ToString() ;
        }


        #endregion

        #region 发送邮件

        public static string SendMail()
        {
             //qq --> 163   成功 ,缺少认证
            //SmtpClient client = new SmtpClient("smtp.qq.com", 587);
            //client.EnableSsl = true;
            ////账户和授权码
            //client.Credentials = new NetworkCredential("1580737718@qq.com", "prwbukqflorsgjci");

            //MailMessage mail = new MailMessage();
            //mail.From = new MailAddress("1580737718@qq.com");
            //mail.To.Add(new MailAddress("anxixuan1@163.com"));

            //mail.IsBodyHtml = true;
            //mail.Priority = MailPriority.High;
            //mail.Subject = "这是主题";
            //mail.Body = "这是内容";
            //client.Send(mail); 
                    



            // 163 --> qq   成功 
            SmtpClient client = new SmtpClient("smtp.163.com", 25);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("anxixuan1@163.com", "anxixuan12");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("anxixuan1@163.com");
            mail.To.Add(new MailAddress("1580737718@qq.com"));

            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;
            mail.Subject = "这是主题";
            mail.Body = "这是内容";
            client.Send(mail); 
            //*/
            return "OK";
        }

        #endregion
       
    }
    class Person {
        public Person(string name,int age){
            this.name = name;
            this.age = age;
        }
        public string name { get; set; }
        public int age { get; set; }
        //public override bool Equals(object obj)
        //{
        //    Person p = obj as Person;
        //    if (this.age == p.age)
        //        return true;
        //    else
        //        return false;
        //    return base.Equals(obj);
        //}
    }
}
