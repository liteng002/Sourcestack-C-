using CSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Data.Common;



namespace Sourcestack
{
    public class Program
    {
        public static void Main(string[] args) {

            //注册 / 登录
            //内容：
            //发布 / 修改
            //批量标记Message为已读
            //string name = Console.ReadLine();
            //string password = Console.ReadLine();

            string connectionString =
                             @"Data Source=(localdb)\MSSQLLocalDB;
                             Initial Catalog=17bang;
                             Integrated Security=True;";
            ////IDbConnection connection = new SqlConnection(connectionString);
            ////connection.Open();
            //using (IDbConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    IDbCommand command = new SqlCommand();
            //    command.Connection = connection;
            //    command.CommandText = "SELECT [Password] FROM [User]" +
            //                            $"WHERE [UserName]=N'{name}'";
            //    object oPassword = command.ExecuteScalar();

            //    if (oPassword == null)
            //    {
            //        Console.WriteLine("用户名输入错误");
            //        return;
            //    }
            //    else if (password != oPassword.ToString())
            //    {
            //        Console.WriteLine("用户名或密码错误");
            //    }
            //    else
            //    {
            //        Console.WriteLine("登录成功");
            //    }


            //    int id = int.Parse(Console.ReadLine());
            //    string title = Console.ReadLine();
            //    string content = Console.ReadLine();
            //    int needRemoteHelp = int.Parse(Console.ReadLine());
            //    int reward = int.Parse(Console.ReadLine());
            //    using (DbConnection Dbconnection = new SqlConnection(connectionString))
            //    {
            //        Dbconnection.Open();
            //        DbCommand command1 = new SqlCommand();
            //        command1.Connection = Dbconnection;
            //        //dbCommand.CommandText = $"INSERT Problem(Id,Title,Content,NeedRemoteHelp,Reward) VALUES({id},N'{title}',N'{content}',{NeedRemoteHelp},{Reward})";
            //        command1.CommandText = $"UPDATE Problem SET Reward = 101 WHERE ID >100 ";
            //        command1.ExecuteNonQuery();
            //    }
            //单页呈现
            // using (DbConnection connection = new SqlConnection(connectionString))
            //{
            //	connection.Open();
            //	DbCommand command = new SqlCommand();
            //	command.Connection = connection;
            //	command.CommandText = "SELECT * FROM Problem";
            //	DbDataReader dbDataReader = command.ExecuteReader();
            //	while (dbDataReader.Read())
            //	{
            //		for (int i = 0; i < dbDataReader.FieldCount; i++)
            //		{
            //			Console.Write(dbDataReader[i]+"     ");
            //		}
            //		Console.WriteLine();
            //	}
            //}
            //		列表页呈现（包括：过滤 / 分页）
            //    Console.WriteLine("选择跳转到第几页");
            //int option = int.Parse(Console.ReadLine());
            //using (DbConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    DbCommand dbCommand = new SqlCommand();
            //    dbCommand.Connection = connection;

            //    dbCommand.CommandText = $"SELECT *FROM" +
            //        $"( SELECT *, ROW_NUMBER() OVER(ORDER BY ID ) DID FROM Problem) pp " +
            //        $"WHERE pp.DID BETWEEN {option * 3 - 2} AND {option * 3} ";
            //    DbDataReader dbDataReader = dbCommand.ExecuteReader();
            //    while (dbDataReader.Read())
            //    {
            //        for (int i = 0; i < dbDataReader.FieldCount; i++)
            //        {
            //            Console.Write(dbDataReader[i] + "     ");
            //        }
            //        Console.WriteLine();
            //    }

            //}

            //用“参数化查询”改写之前拼接的SQL代码

            string id = Console.ReadLine();
            using (DbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                DbCommand command = new SqlCommand();
                command.Connection = dbConnection;
                command.CommandText = $"SELECT * FROM Problem WHERE ID = {id}";
                //DbParameter pId = new SqlParameter("@id", id);
                //command.Parameters.Add(pId);
                DbDataReader dbDataReader = command.ExecuteReader();
                dbDataReader.Read();
                Console.WriteLine($"{dbDataReader[0]}+{dbDataReader[1]}");
            }

            //用事务完成帮帮币的交易
            int amount = int.Parse(Console.ReadLine());
            int balance = int.Parse(Console.ReadLine());
            int userId = int.Parse(Console.ReadLine());
            using (DbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                IDbCommand dbCommand = new SqlCommand();
                dbCommand.Connection = connection;
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        dbCommand.Transaction = transaction;
                        dbCommand.CommandText = $"INSERT BangMoney  VALUES(@amount,@balace,@userId)";
                        DbParameter dbamount = new SqlParameter("@amount", amount);
                        DbParameter dbbalace = new SqlParameter("@balace", balance);
                        DbParameter dbuserId = new SqlParameter("@userId", userId);

                        dbCommand.Parameters.Add(dbamount);
                        dbCommand.Parameters.Add(dbbalace);
                        dbCommand.Parameters.Add(dbuserId);
                        dbCommand.ExecuteNonQuery();
                        
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}

