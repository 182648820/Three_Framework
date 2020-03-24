using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModel
{
    public class MyModelDemo
    {
        //声明字段
        public static string pNames;
        public static string pAges;
        public static string pSexs;
        public static string PNames {set { pNames = value; } get { return pNames; } }
        public static string PAges { set { pAges = value; } get { return pAges; } }
        public static string PSexs { set { pSexs = value; } get { return pSexs; } }


    }
}
