<%@ WebHandler Language="C#" Class="ValidateCodeHandler" %>

using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

public class ValidateCodeHandler : IHttpHandler, System.Web.SessionState.IRequiresSessionState 
{
    public void ProcessRequest (HttpContext context) 
    {
        //定义图片的宽度
        int ImageWidth = 55;
        //定义图片高度
        int ImageHeigh = 22;
        //定义字体，用于绘制文字
        Font font = new Font("Arial", 12, FontStyle.Bold);
        //定义画笔，用于绘制文字
        Brush brush = new SolidBrush(Color.Black);
        //定义钢笔，用于绘制干扰线
        Pen pen1 = new Pen(Color.FromArgb(255, 100, 100), 0);//这里也可以直接获得一个现有的color对象如：Color.Gold.我是为了美观所以定义和下面一样
        Pen pen2 = new Pen(Color.FromArgb(255, 100, 100), 0);//这里根据ARGB值定义获得了一个color对象
        //创建一个图像
        Bitmap BitImage = new Bitmap(ImageWidth, ImageHeigh);
        //从图像获取一个绘画面
        Graphics graphics = Graphics.FromImage(BitImage);
        //清除整个绘图画面并用颜色填充
        graphics.Clear(ColorTranslator.FromHtml("#F0F0F0"));//这里从HTML代码获取color对象
        //定义文字的绘制矩形区域
        RectangleF rect = new RectangleF(5, 2, ImageWidth, ImageHeigh);
        //定义一个随机数对象，用于绘制干扰线
        Random rand = new Random();
        //生成两条横向的干扰线
        for (int i = 0; i < 2; i++)
        {
            //定义起点
            Point p1 = new Point(0, rand.Next(ImageHeigh));
            //定义终点
            Point p2 = new Point(ImageWidth, rand.Next(ImageHeigh));
            //绘制直线
            graphics.DrawLine(pen1, p1, p2);
        }
        //生成两条纵向的干扰线
        for (int i = 0; i < 2; i++)
        {
            //定义起点
            Point p1 = new Point(rand.Next(ImageWidth), 0);
            //定义终点
            Point p2 = new Point(rand.Next(ImageWidth), ImageHeigh);
            //绘制直线
            graphics.DrawLine(pen2, p1, p2);
        }
        //绘制验证码文字
        string checkcode = CreateCheckCodeString();
        context.Session["CheckCode"] = checkcode.ToLower();//验证码存储在Session中，供验证。
        graphics.DrawString(checkcode, font, brush, rect);
        //输出到浏览器
        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        //保存图片为gif格式
        BitImage.Save(ms, ImageFormat.Jpeg);
        context.Response.ClearContent();//清空输出流
        context.Response.ContentType = "image/Jpeg";//输出流的格式
        context.Response.BinaryWrite(ms.ToArray());//输出
        context.Response.End();
    }
 
    public bool IsReusable 
    {
        get {
            return false;
        }
    }
    
    private static string CreateCheckCodeString()
    { //定义用于验证码的字符数组
        char[] AllCheckCodeArray ={ '0','1','2','3','4','5','6','7','8','9','A','B','C',
        'D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W',
        'X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q',
        'r','s','t','u','v','w','x','y','z'};
        //定义验证码字符串
        string randomcode = "";
        Random rd = new Random();
        //生成4位验证码字符串
        for (int i = 0; i < 4; i++)
            randomcode += AllCheckCodeArray[rd.Next(AllCheckCodeArray.Length)];

        return randomcode;
    }

}