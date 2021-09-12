using CSharp;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Sourcestack
{

    public class Program
    {


        //函数GetDate()，能计算一个日期若干（日/周/月）后的日期
        public static DateTime GetDate(DateTime dateTime, int count, GetDateTime unit) {
            switch (unit)
            {
                case CSharp.GetDateTime.Days:
                    dateTime = dateTime.AddDays(count);
                    break;
                case CSharp.GetDateTime.Weeks:
                    dateTime = dateTime.AddDays(count * 7);
                    break;
                case CSharp.GetDateTime.Months:
                    dateTime = dateTime.AddMonths(count);
                    break;
                default:
                    break;
            }

            return dateTime;
        }

        //给定任意一个年份，就能按周排列显示每周的起始日期
        public static void GetDateTime(DateTime dateTime) {
            for (int i = 1; i < 365 / 7; i++)
            {
                Console.WriteLine($"第{i}周：{dateTime.ToString("yyyy年MM月dd日")}-{dateTime.AddDays(7).ToString("yyyy年MM月dd日")}");
                dateTime = dateTime.AddDays(7);
            }
        }

        //在Content之外封装一个方法，可以修改Content的CreateTime和PublishTime
        //public static void SetCreateTime(Content content, DateTime dateTime) {
        //    typeof(Content).GetProperty(
        //        "CreateTime", BindingFlags.Public | BindingFlags.Instance)
        //        .SetValue(content, dateTime);
        //}

        //public static void SetPublishTime(Content content, DateTime dateTime) {

        //    typeof(Content).GetProperty(
        //            "CreateTime", BindingFlags.Public | BindingFlags.Instance)
        //            .SetValue(content, dateTime);
        //}

        //实现GetCount(string container, string target)方法，可以统计出container中有多少个target
        public static int GetCount(string container, string target) {
            int result = 0;
            while (container.Contains(target))
            {
                container = container.Substring(container.IndexOf(target + target.Length));
            }
            return result;
        }

        //不使用string自带的Join()方法，定义一个mimicJoin()方法，能将若干字符串用指定的分隔符连接起来，
        //比如：mimicJoin("-","a","b","c","d")，其运行结果为：a-b-c-d

        public static string MimicJoin(string interval, string[] value) {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                sb = sb.Append(value[i]);
                if (i < value.Length - 1)
                {
                    sb.Append(interval);
                }
            }
            return sb.ToString();
        }


        public static void Main(string[] args) {
            //实例化上述类，得到他们的对象：
            //给对象的字段赋值
            //调用对象的方法
            //调用这些类的有参/无参构造函数，生成这些类的对象，调用他们的方法

            User lt = new User("李腾", "432");
            // lt.Name = "李腾";
            Console.WriteLine(lt.Name);
            lt.Register();

            HelpMoney coin = new HelpMoney();


            Problem query = new Problem("内容", "2");
            //实例化文章和意见建议，调用他们：
            //继承自父类的属性和方法
            //自己的属性和方法

            Article wz = new Article(3);


            Suggest yjjy = new Suggest(1);


            //int i = null; 
            DateTime dateTime = new DateTime(2019, 3, 4);
            GetDateTime unit = CSharp.GetDateTime.Weeks;
            Console.WriteLine(GetDate(dateTime, count: 1, unit));

            GetDateTime(new DateTime(2011, 1, 1));

            //思考dynamic和var的区别，并用代码予以演示
            dynamic dynamic;
            //var v ;
            //var 是 编译时赋值，dynamic 是 运行时赋值
            //var 编译时不赋值会报错，dynamic不会且运行时也不会报错

            //构造一个能装任何数据的数组，并完成数据的读写
            object[] array = new object[] { 32, 22.2, "李", true, new User("用户", "uii321") };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //用反射获取Publish()上的特性实例，输出其中包含的信息
            Attribute attribute = HelpMoneyChangedAttribute.GetCustomAttribute(
                typeof(Problem).GetMethod("Publish"),
                typeof(HelpMoneyChangedAttribute));
            Console.WriteLine((HelpMoneyChangedAttribute)attribute);





            //给User添加权限
            User yf = new User("叶飞", "1234");
            yf.Tokens = new TokenManager();
            yf.Tokens.Add(Token.Admin);
            yf.Tokens.Has(Token.Blogger);
            yf.Tokens.Remove(Token.Newbie);



            //一篇文章可以有多个评论
            //Article article = new Article(1);
            //Comment comment1 = new Comment() { Discuss = "你好", Article = article };
            //Comment comment2 = new Comment() { Discuss = "我好", Article = article };
            //Comment comment3 = new Comment() { Discuss = "大家好", Article = article };
            //article.Comment = new List<Comment> { comment1, comment2, comment3 };

            ////一个评论必须有一个它所评论的文章
            //Comment comment = new Comment();
            //Article article1 = new Article(1) { Contents = "这是文章内容" };
            //comment.Article = article1;

            ////每个文章和评论都有一个评价
            //Comment comment4 = new Comment();
            //Article article2 = new Article(1);
            //Appraise appraise = new Appraise();
            //comment4.Appraise = new Appraise();
            //article2.Appraise = new Appraise();

            ////一篇文章可以有多个关键字，一个关键字可以对应多篇文章
            //Keyword keyword1 = new Keyword() { KeywordName = "SQL" };
            //Keyword keyword2 = new Keyword() { KeywordName = "C#" };
            //Keyword keyword3 = new Keyword() { KeywordName = "Html" };
            //Keyword keyword4 = new Keyword() { KeywordName = "JavaScript" };
            //Article article3 = new Article(1);
            //Article article4 = new Article(2);
            //Article article5 = new Article(1);
            //article.keywords = new List<Keyword> { keyword1, keyword3, keyword4 };
            //keyword1.Articles = new List<Article> { article3, article4, article5 };




            //在之前“文章/评价/评论/用户/关键字”对象模型的基础上，添加相应的数据，然后完成以下操作：
            User fg = new User("飞哥", "1234");
            User xy = new User("小鱼", "1234");
            IEnumerable<User> users = new List<User> { fg, xy };

            Problem problem1 = new Problem(Body: "正文", king: "article") { Author = fg };


            Console.WriteLine(fg.Name);







            Console.WriteLine();








            //Console.WriteLine("请输入用户名和密码");
            //bool successful = LogOn(Console.ReadLine(), Console.ReadLine(), out string why);
            //Console.WriteLine(successful + why);

            //User password = new User();
            //password._password = "1234";

            //Sourcestack.User name = new User();
            //name.name = "admin";
            //Console.WriteLine(name.name);

            //Problem questions = new Problem();
            //Problem.Publish();

            //User account = new User();
            //account.Register();

            //User successful = new User();
            //successful.Login();

            //Problem heip = new Problem();
            //heip[1] = "C#";

            //Console.WriteLine(heip[1]);


            //GetArray();



            //Console.WriteLine(LogOn("叶子","yefei", out string why));


            // array();




            //实现二分查找，方法名BinarySeek(int[] numbers, int target)：
            //传入一个有序（从大到小 / 从小到大）数组和数组中要查找的元素
            //  如果找到，返回该元素所在的下标；否则，返回 - 1
            //Console.WriteLine(BinarYseek(new int[] { 13, 24, 35, 46, 57, 68 }, 4));






            ///利用ref调用Swap()方法交换两个同学的床位号
            //int upper = 9;
            //int lower = 1;
            //Swap(ref upper, ref lower);
            //  Console.WriteLine(upper);


            //完成“猜数字”游戏，方法名GuessMe()：
            // GuessMe();

            //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
            //Console.WriteLine(GetAverage(new double[] { 12.346, 34.764, 86.536, 995, 68.23 }));











            //输出两个整数/小数的和/差/积/商
            //double a = 88, b = 25.3, c = 7, d = 12.1;
            //Console.WriteLine();


            //忘了/**/这个注释快捷键了
            //小数点后两位/网上抄的四舍五入法以及截断法，飞哥给讲讲
            //[(23 + 7)*12 - 8]/ 6    
            //float i = ((23 + 7) * 12 - 8) / 6f;
            //string show = i.ToString("0.00");
            //Console.WriteLine(i);

            /*float i = ((23 + 7) * 12 - 8) / 6F;
            int j = (int)(i * 100);
            i = j * 0.01F;
            Console.WriteLine(i);*/


            // 想一想如下代码的结果是什么，并说明原因：
            ////我自己理解的3号 i 是二次赋值（覆盖1号 i ），4号 i 的结果应该是10（F5答案是11），2号 i 是个输出窗口（为什么会计算在内）
            //int i = 15;                  //1号  i

            // Console.WriteLine(i++);      //2号   i           
            // // i = i - 5;
            // i -= 5;                       //3号  i       

            // Console.WriteLine(i);        //4号   i

            // Console.WriteLine(i >= 10);
            // Console.WriteLine("i值的最终结果为：" + i);

            //int j = 20;
            //Console.WriteLine($"{i}+{j}={i + j}");     //算的是true,算错了



            //  想一想如下代码的结果是什么，并说明原因：  按照运算符等级来算 （）> () > ! > || > &&
            //int a = 10;
            //Console.WriteLine(a > 9 && (!(a < 11) || a > 10));      //false






            //当a为何值时，结果为true？
            //int a = 10;
            //bool result = (a + 3 > 12) && a < 3.14 * 4 && a != 11;

            //Console.WriteLine(result);







            //作业：将源栈同学姓名 / 昵称分别：
            //          按进栈时间装入一维数组，
            //          按座位装入二维数组，
            //          并输出共有多少名同学。

            // string[] name = { "1号", "2号", "3号", "4号", "5号", "6号", "7号", "8号" };
            // Console.WriteLine(name[1]);
            // Console.WriteLine(name.Length);


            // string[,] sname = { { "1号", "2号", "3号", "4号", "5号", "6号", "7号", "8号" }, { "赵", "钱", "孙", "李", "周", "吴", "郑", "王" } };
            // Console.WriteLine(sname[0, 1]);
            // Console.WriteLine(sname.Rank);
            // Console.WriteLine(sname.GetLength(1));



            // //getlength 不能计算交错数组的二维长度？？？ rank好像也不能计算有几个交错数组   length好像也不是总长度
            // string[][] names = new string[3][];
            // names[0] = new string[] { "1号", "4号", "7号" };
            // names[1] = new string[] { "2号", "5号", "8号" };
            // names[2] = new string[] { "3号", "6号" };
            // Console.WriteLine(names[1][0]);
            //// Console.WriteLine(names.Length);


            //分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9

            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 1; i < 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            // int i = 1;
            //while (i < 6)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i += 2;
            //}

            ////用for循环输出存储在一维/二维数组里的源栈所有同学姓名/昵称
            //string[] name = { "1号", "2号", "3号", "4号", "5号", "6号", "7号", "8号" };
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}
            //
            //string[,] sname = { { "1号", "2号", "3号", "4号", "5号", "6号", "7号", "8号" }, { "赵", "钱", "孙", "李", "周", "吴", "郑", "王" } };
            //for (int i = 0; i < sname.GetLength(0); i++)
            //{
            //    for (int j = 0; j < sname.GetLength(1); j++)
            //    {
            //        string abs = sname[i, j];
            //        Console.WriteLine(abs);

            //    }
            //}

            //让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //int sum = 0;
            //for (int i = 99; i >= 1; i -= 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);




            // 找到100以内的所有质数（只能被1和它自己整除的数） 
            //for (int i = 2; i <= 100; i++)
            //{
            //    bool a = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            a = false;
            //        }//else  nothing
            //    }
            //    if (a == true)
            //    {
            //        Console.WriteLine(i);
            //    }//else nothing
            //}

            //生成一个元素（值随机）从小到大排列的数组（冒泡）

            //int[] random = { 7, 6, 12, 3, 4, 9, 7, 8 };
            //for (int i = 1; i < random.Length; i++)
            //{


            //    for (int j = 0; j < random.Length - 1; j++)
            //    {
            //        if (random[j] > random[j + 1])
            //        {
            //            int a = random[j];
            //            random[j] = random[j + 1];
            //            random[j + 1] = a;
            //        }
            //    }
            //}
            //for (int i = 0; i < random.Length; i++)
            //{
            //    Console.WriteLine(random[i]);
            //}

            ////设立并显示一个多维数组的值，元素值等于下标之和。Console.Write()

            //int[,] a = { { 0, 1, 2, 3 }, { 1, 2, 3, 4 }, { 2, 3, 4, 5 } };
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        int b = a[i, j];
            //        Console.Write(b);
            //        Console.Write("\t");
            //    }
            //    Console.Write("\n");
            //}


            ////二分查找  如果没找到？        - -`           
            //int[] array = { 1, 2, 5, 12, 14, 15, 16, 20, 22, 30 };
            //int left = 0, right = array.Length - 1, target = 3;
            //int result = -1;
            //while (left <= right)
            //{
            //    int middle = (left + right) / 2;
            //    if (target == array[middle])
            //    {
            //        result = middle;
            //        break;
            //    }
            //    else if (target > array[middle])
            //    {
            //        left = middle + 1;
            //    }
            //    else
            //    {
            //        right = middle - 1;
            //    }
            //}
            //if (result != -1)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("找不到");
            //}




            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] results = {- 555, 6, 2, 7, 9, 4, 8, -383};
            //double max = results[0];
            //double min = results[0];
            //for (int i = 1; i < results.Length; i++)
            //{
            //    if (max < results[i])
            //    {
            //        max = results[i];
            //    }  // else  nothing   

            //    if (min > results[i])
            //    {
            //        min = results[i];
            //    }// else nothing
            //}
            //Console.WriteLine(min);














            //https://17bang.ren/Article/305
            //            1.观察“一起帮”的：
            //1.(1)注册 / 登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
            //1.(2)求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
            //1.(3)帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
            //2.为这些类的字段和方法设置合适的访问修饰符。


            Console.ReadLine();

        }
        //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
        //static double GetAverage(double[] scores)
        //{
        //    double sum = 0;
        //    for (int i = 0; i < scores.Length; i++)
        //    {
        //        // Console.WriteLine(results[i]);
        //        sum = sum + scores[i];

        //    }
        //    return Math.Round(sum/scores.Length, 2);
        //}



        //完成“猜数字”游戏，方法名GuessMe()：
        //随机生成一个大于0小于1000的整数
        //用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
        //没猜中可以继续猜，但最多不能超过10次
        //如果5次之内猜中，输出：你真牛逼！
        //如果8次之内猜中，输出：不错嘛！
        //10次还没猜中，输出：(～￣(OO)￣)ブ
        // 1-5 次  你真牛逼         6-8 次   不错嘛     9-10 次 猜中了哟     猜不中(～￣(OO)￣)ブ
        //public static void GuessMe()
        //{
        //    Console.WriteLine("请输入0-1000以内的一个数字");
        //    int random = new Random().Next(0, 1000);
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        int input = int.Parse(Console.ReadLine());

        //        if (input == random)
        //        {
        //            if (i <= 5)
        //            {
        //                Console.WriteLine($"你真牛逼只用了{ i}次");
        //            }
        //            else if (i <= 8)
        //            {
        //                Console.WriteLine($"不错嘛只用了{ i}次");
        //            }
        //            else if (i <= 10)
        //            {
        //                Console.WriteLine($"猜中了哟只用了{ i}次");
        //            }
        //            return;
        //        }
        //        else if (input != random)
        //        {
        //            if (i == 10)
        //            {
        //                Console.WriteLine("(～￣(OO)￣)ブ");
        //                return;
        //            }
        //            if (input > random)
        //            {
        //                Console.WriteLine($"太大了哟还剩{10 - i}次");
        //            }
        //            else //input < random
        //            {
        //                Console.WriteLine($"太小了呢还剩{10 - i}次");
        //            }
        //        }
        //    }
        //}
        ///利用ref调用Swap()方法交换两个同学的床位号
        //static int Swap(ref int upper, ref int lower)
        //{

        //    int middle = upper;
        //    upper = lower;
        //    lower = middle;
        //    return upper;

        //}








        //  
        ///https://17bang.ren/Article/641
        // 定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制：
        //最小值min（默认为1）
        //相邻两个元素之间的最大差值gap（默认为5） 
        //元素个数length（默认为10个）
        //static int[] GetArray(int min = 1, int lengh = 10, int gap = 5)
        //{
        //    int[] array = new int[lengh];
        //    array[0] = min;
        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        array[i] = new Random().Next(gap) + array[i - 1];
        //        Console.WriteLine(array[i]);
        //    }
        //    return array;
        //}


        //将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
        //true / false，表示登陆是否成功
        //string，表示登陆失败的原因
        //static bool LogOn(string name, string password, out string why)
        //{

        //   why = "用户名不存在";
        //    if (name != "叶子" && password != "yefei")
        //    {
        //        //why = "用户名不存在";
        //    }
        //    else if (name == "叶子" && password != "yefei")
        //    {
        //        why = "密码错误";
        //    }
        //    else if (name == "叶子" && password == "yefei")
        //    {
        //        why = "登录成功";
        //        return true;
        //    }//else nothing  
        //    return false;
        //}

    }
}
