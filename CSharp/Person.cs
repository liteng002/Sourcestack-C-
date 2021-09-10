using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    // 1. 声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型
    public delegate int ProvideWater(Person person);
    public class Person
    {

        //2.使用：
        //方法
        //匿名方法
        //lambda表达式
        //给上述委托赋值，并运行该委托
        public int Age
        {
            get; set;
        }
        public int GetFunc(Person person) {
            return -1;
        }

        public static void Execute() {
            ProvideWater provideWater = new ProvideWater(new Person().GetFunc);
            provideWater(new Person());
            provideWater += delegate (Person Person) { return 1; };
            provideWater += (Person) => 3;
        }
    


    //3.声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出
    public static int GetWater(ProvideWater opt) {

        Console.WriteLine(opt(new Person()));
        return opt(new Person());
    }








}
}
