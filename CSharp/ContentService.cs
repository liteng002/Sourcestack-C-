using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //添加一个新类ContentService，其中
    //如果发布Article，需要Article作者消耗一个帮帮币
    //如果发布Problem，需要消耗Problem作者其设置悬赏数量的帮帮币
    //如果发布Suggest，不需要消耗帮帮币
    //最后将内容存到数据库中，三个类存数据库的方法是完全一样的，现在用Console.WriteLine("saved into db")代替。
    class ContentService
    {

        //在ContentService中捕获异常
        //如果是“参数为空”异常，Console.WriteLine() 输出：内容的作者不能为空，
        //将当前异常封装进新异常的InnerException，再将新异常抛出
        //// 如果是“”参数越界”异常，Console.WriteLine() 输出：求助的Reward为负数（-XX），不再抛出异常
        //ContentService中无论是否捕获异常，均要Console.WriteLine() 输出：XXXX年XX月XX日 XX点XX分XX秒（当前时间），
        //请求发布内容（Id=XXX）
        public void Publish(Content content) {

            try
            {
                content.Publish();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"{DateTime.Now.ToString("yyyy年mm月dd日 hh点mm分ss秒")}内容的作者不能为空");
                throw new Exception("内容的作者不能为空", e);
            }
            catch (ArrayTypeMismatchException)
            {
                Console.WriteLine($"求助的Reward为负数（-XX），不再抛出异常");

            }
            finally
            {
                Console.WriteLine($"{DateTime.Now.ToString("yyyy年mm月dd日 hh点mm分ss秒")}请求发布内容（Id=XXX）");
            }
        }



        //有一个发布（Release()）方法：
        public virtual void Release(ContentService contentService) {


        }
    }
}
