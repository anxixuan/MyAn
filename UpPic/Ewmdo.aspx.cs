
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using BaseClass;
using System;
using System.IO;
using System.Drawing;
using ZXing;
using ZXing.Presentation;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;
namespace MTT
{
    public partial class html5upload_ewmdo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request["action"] == "PostEwm")
            {
                //try
                //{
                //    QRCodeDecoder decoder = new QRCodeDecoder();
                //    byte[] imgBytes = Convert.FromBase64String(Request["img"]);
                //    Stream stream = new MemoryStream(imgBytes);
                //    String decodedString = decoder.decode(new QRCodeBitmapImage(new Bitmap(stream)),Encoding.UTF8);

                //    Response.Write(decodedString);

                //}
                //catch
                //{
                //}
                try
                {

                    byte[] imgBytes = Convert.FromBase64String(Request["img"]);
                    Stream stream = new MemoryStream(imgBytes);
                    Result result = new ZXing.BarcodeReader().Decode(new Bitmap(stream));
                    Response.Write(result.Text);
                    Response.End();
                }
                catch { Response.Write(""); Response.End(); }
            }
            else if (Request["action"] == "PostEwmAddFile")
            {
                try
                {
                    string filename = Request["filename"];
                    byte[] imgBytes = Convert.FromBase64String(Request["img"].Remove(0, Request["img"].IndexOf(',')+1));               
                    Stream stream = new MemoryStream(imgBytes);
                    MemoryStream memory= new MemoryStream(imgBytes);
                    FileStream fs = new FileStream(Server.MapPath("/file/upload/")+filename, FileMode.Create);
                    //StreamWriter sw = new StreamWriter(stream);
                    //开始写入
                    //sw.Write(stream);
                    //清空缓冲区
                    //sw.Flush();
                    //关闭流
                   // sw.Close();
                    memory.WriteTo(fs);
                    fs.Close();

                    //Bitmap btp = new Bitmap(stream);
                   // btp.Save(Server.MapPath("/file/upload/")+ filename);

                }
                catch
                {
                }
                
            }
        }
    }
}