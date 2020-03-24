using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaterDal;
using System.Data.SqlClient;
using MyModel;
using System.Data;

namespace MyDal
{
    public class MyDalDemo
    {

        //public int Operate(string str_1, string str_2, string str_3)
        //{
        //    string sql = "insert into Person(Name, Age, Sex) values(@name, @age, @sex)";
        //    SqlParameter[] ps =
        //     {
        //        new SqlParameter("@name", str_1),
        //        new SqlParameter("@age", str_2),
        //        new SqlParameter("@sex", str_3)
        //    };
        //    return SqliteHelper.ExecuteNonQuery(sql, ps);
        //}

        string sql;
        public int Operate()
        {
            // MyModelDemo model = new MyModelDemo();
            sql = "insert into Person(Name, Age, Sex) values(@name, @age, @sex)";
            SqlParameter[] ps =
             {
                new SqlParameter("@name", MyModelDemo.PNames),
                new SqlParameter("@age", MyModelDemo.PAges),
                new SqlParameter("@sex", MyModelDemo.PSexs)
            };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public DataTable Selet()
        {
            sql = "select * from Person";
            return SqliteHelper.GetDataTable(sql);
        }
        public int Delet()
        {
            //不能通过控件名来获取相关文本，因为这里没有引用控件的任何消息
            //在执行层 要想获取数据 一般从Model模型这边获取 或者UI层通过BLL层向这边传送
            sql = "delete from Person where Name = @Name";
            SqlParameter[] ps = { new SqlParameter("@Name", MyModelDemo.PNames) };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Modify()
        {
            sql = "update  Person set  Age= @age, Sex=@sex where Name = @name" ;
            SqlParameter[] ps = {
                new SqlParameter("@name", MyModelDemo.PNames),
                new SqlParameter("@age", MyModelDemo.PAges),
                new SqlParameter("@sex", MyModelDemo.PSexs)};

            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
    }
}
