using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBll;
using MyModel;
namespace applyFrame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyBllDemo bllDemo = new MyBllDemo(); //定义一个BLL层的类

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region 面向过程：任务逐语句执行
            //if(bllDemo.Operate(pName.Text, Age.Text, Sex.Text) > 0)
            //{
            //    MessageBox.Show("添加成功");
            //    pName.Clear();
            //    Age.Clear();
            //    Sex.Clear();
            //}
            #endregion


            //面向对象：逐过程
            InitData();
            MyModelDemo model = new MyModelDemo();
            
            if (bllDemo.Operate() > 0)
            {
                MessageBox.Show("添加成功");
                pName.Clear();
                Age.Clear();
                Sex.Clear();
            }
            Update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            InitData();
            if (bllDemo.Delet()>0)
            {
                MessageBox.Show(MyModelDemo.PNames+"相关信息删除成功");
                Update();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Update();
        }
        #region 更新/初始化
        public void Update()  //更新
        {
            dataView.DataSource = bllDemo.Selet();
        }
        public void InitData()
        {

            MyModelDemo.PNames = pName.Text;
            MyModelDemo.PAges = Age.Text;
            MyModelDemo.PSexs = Sex.Text;
        }
        #endregion

        private void btnModify_Click(object sender, EventArgs e)
        {
            InitData();
            if(bllDemo.Modify()>0)
            {
                MessageBox.Show(MyModelDemo.PNames+"的信息修改成功");
                Update();
            }
        }

        //这个功能实现点击dataView某行时 将这一行的一些信息送到其他文本框中
        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Row = dataView.Rows[e.RowIndex]; //获取dataView表的当前操作行
            pName.Text = Row.Cells[1].Value.ToString();
            Age.Text = Row.Cells[2].Value.ToString();
            Sex.Text = Row.Cells[3].Value.ToString();
        }
    }
}
