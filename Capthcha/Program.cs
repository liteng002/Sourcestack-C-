using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capthcha
{
    class Program
    {

        public static string GetStr(string str,Random rd) {
            string str1 = null;
            for (int i = 0; i < 4; i++)
            {
                string str2 = str.Substring(rd.Next(0, str.Length - 1), 1);

                str1 += str2;
            }
            return str1;
        }

        public static void GetLine(Random rd,Bitmap image,Graphics g)
        {
            for (int i = 0; i < 15; i++)
            {
                Color formArgb = Color.FromArgb(rd.Next(255), rd.Next(255), rd.Next(255));
                Point p1 = new Point(rd.Next(0, image.Width), rd.Next(0, image.Height));
                Point p2 = new Point(rd.Next(0, image.Width), rd.Next(0, image.Height));
                g.DrawLine(new Pen(formArgb), p1, p2);
            }
        }

        public static void GetDot(Random rd,Bitmap image)
        {
            for (int i = 0; i < 100; i++)
            {
                Color formArgb = Color.FromArgb(rd.Next(255), rd.Next(255), rd.Next(255));
                image.SetPixel(rd.Next(0, image.Width), rd.Next(0, image.Width),formArgb);
            }

        }

        public static void GetDrawString(Random rd, Graphics g, string str)
        {
            for (int i = 0; i < 4; i++)
            {
                                Color formArgb = Color.FromArgb(rd.Next(255), rd.Next(255), rd.Next(255));
                char[] ofA = str.ToCharArray();
                string[] fonts = { "黑体", "宋体", "隶书" };
                Point p = new Point(i * 20, 5);
                g.DrawString(
                    ofA[i].ToString(),
                    new Font(fonts[rd.Next(0, 5)], 20),
                    new SolidBrush(formArgb),
                    p);
            }
        }

        static void Main(string[] args)
        {
            //参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含：
            //随机字符串
            //混淆用的各色像素点
            //混淆用的直线（或曲线）

          

            try
            {
                Bitmap image = new Bitmap(100, 50);
                Graphics g = Graphics.FromImage(image);
                g.Clear(Color.White);
                Random rd = new Random();
                string str = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890";
                string fourstr = GetStr(str,rd);
                GetDrawString(rd,g,fourstr);
                GetLine(rd,image,g);
                GetDot(rd,image);
                image.Save(@"D:\captcha.jpg");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
