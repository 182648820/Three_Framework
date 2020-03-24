using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDal;
using System.Data;

namespace MyBll
{
    public class MyBllDemo
    {
        MyDalDemo dalDemo = new MyDalDemo(); //定义一个dal层的类
                                             //public int Operate(string str_1, string str_2, string str_3)
                                             //{
                                             //    return dalDemo.Operate(str_1, str_2, str_3);
                                             //}
        public int Operate() //添加
        {
            return dalDemo.Operate();
        }
        public DataTable Selet() //查询
        {
            
            return dalDemo.Selet();
        }
        public int Delet()
        {

            return dalDemo.Delet();
        }

        public int Modify()
        {
      
            return dalDemo.Modify();
        }
    }
}
