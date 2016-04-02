using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 三角湖度假村管理系统
{
    public partial class 餐饮项目 : Form
    {
        public void ClearEditMSection()
        {
            this.label12.Text = "";
            this.txtmenu.Text = "";
            this.txtMprice.Text = "";
            this.CboMtype.Text = "";
        }
        public void BindMenu(string sql)
        {
            if (sql == System.String.Empty)
            {
                this.dgvFood.DataSource = OrdermealManager.GetMenuAll();
            }
            else
            { this.dgvFood.DataSource = OrdermealManager.GetMenu(sql); }

        }
        public void BindMenu2(string sql)
        {
            if (sql == System.String.Empty)
            {
                this.dgvFood2.DataSource = OrdermealManager.GetMenuAll();
            }
            else
            { this.dgvFood2.DataSource = OrdermealManager.GetMenu(sql); }

        }
        public 餐饮项目()
        {
            InitializeComponent();
        }

        private void 餐饮项目_Load(object sender, EventArgs e)
        {
            string s = System.String.Empty;
            BindMenu(s);
        }
//查询
        private void button4_Click(object sender, EventArgs e)
        {
            string sql = this.CboFood.Text.Trim();
         
            BindMenu(sql);
        }
//新增
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtmenu.Text == string.Empty || this.txtMprice.Text == string.Empty || this.CboMtype.Text == string.Empty)
            {
                MessageBox.Show("请输入完整的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ordermeal _ordermeal=new ordermeal();
            _ordermeal.Price = Convert.ToDecimal(this.txtMprice.Text.Trim());
            _ordermeal.Menu = this.txtmenu.Text.Trim();
            _ordermeal.Type = this.CboMtype.Text.Trim();

            int message = OrdermealManager.AddMenu(_ordermeal);
            if (message == 0)
            {
                MessageBox.Show("该菜品已存在！");
            }
            else
            {
                string sqlm = this.CboMtype.Text.Trim();
                BindMenu(sqlm);
                MessageBox.Show("添加成功！");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

             if (this.txtmenu.Text == string.Empty || this.txtMprice.Text == string.Empty || this.CboMtype.Text == string.Empty)
            {
                MessageBox.Show("请输入完整的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
             string M_id = this.dgvFood.CurrentRow.Cells["id"].Value.ToString();
             string menu0 = this.dgvFood.CurrentRow.Cells["menu"].Value.ToString();
             ordermeal _ordermeal = OrdermealManager.GetMenuById(Convert.ToInt32(M_id));
             _ordermeal.Price = Convert.ToDecimal(this.txtMprice.Text.Trim());
             _ordermeal.Menu = this.txtmenu.Text.Trim();
             _ordermeal.Type = this.CboMtype.Text.Trim();
             bool result =OrdermealManager.ModifyMenu(_ordermeal,menu0);
             if (result)
             {
                 string sqlm = this.CboMtype.Text.Trim();
                 BindMenu(sqlm);
                 MessageBox.Show("修改成功", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
             {
                 MessageBox.Show("修改失败！");
             }
        }
        //删除
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dgvFood.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先单击每行最左边选择要删除的行");
            }
            else
            {
                string a = this.dgvFood.CurrentRow.Cells[2].Value.ToString();
                if (MessageBox.Show("确定删除信息吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = OrdermealManager.DeleteMenu(a);
                    if (result == 1)
                    {
                        MessageBox.Show(string.Format("已删除{0}的信息！", a));
                        string sqlm = this.CboFood.Text.Trim();
                        BindMenu(sqlm);
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
        }
//刷新
        private void button5_Click(object sender, EventArgs e)
        {
            ClearEditMSection();
            string sqlm = this.CboFood.Text.Trim();
            BindMenu(sqlm);
        }

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.label12.Text =dgvFood.Rows[e.RowIndex].Cells["id"].Value.ToString();
            this.txtmenu.Text =dgvFood.Rows[e.RowIndex].Cells["menu"].Value.ToString();
            this.txtMprice.Text =dgvFood.Rows[e.RowIndex].Cells["price"].Value.ToString();
            this.CboMtype.Text =dgvFood.Rows[e.RowIndex].Cells["type"].Value.ToString();
         
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            /*string sqlm = e.Node.Text;
            BindMenu2(sqlm);*/
        }

        private void dgvFood2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.labelDmenu.Text = dgvFood2.Rows[e.RowIndex].Cells["menu"].Value.ToString();
            this.labelDprice.Text = dgvFood2.Rows[e.RowIndex].Cells["price"].Value.ToString();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string sqlm = e.Node.Text;
            if (sqlm == "菜品")
            {
                sqlm = System.String.Empty;
            }
            BindMenu2(sqlm);
        }

        private void btnDian_Click(object sender, EventArgs e)
        {
            if (this.txtIdnum.Text==String.Empty||this.txtQuantity.Text==String.Empty||this.labelDmenu.Text==string.Empty||this.labelDprice.Text==string.Empty)
            {
                MessageBox.Show("请选择商品并填写数量和证件号并选择商品！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToInt32(this.txtQuantity.Text.Trim()) < 0)
            {
                MessageBox.Show("数量不能小于1", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
 
            }
            int result = BillManager.check(this.txtIdnum.Text);
            if (result == 0)
            {
                MessageBox.Show("请先开单再点单！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                billdetail _billdetail = new billdetail();
                _billdetail.Idnumber = this.txtIdnum.Text.Trim();
                _billdetail.Projectnumber = this.labelDmenu.Text.Trim();
                _billdetail.Price = Convert.ToDecimal(this.labelDprice.Text.Trim());
                _billdetail.Days = Convert.ToInt32(this.txtQuantity.Text.Trim());
                result = BilldetailManager.AddBillDetail(_billdetail);
                string sqlbt = "select * from bill where mark='0' and idnumber=" + "'" + _billdetail.Idnumber + "'";
                DataTable billtable = DBHelper.GetDataSet(sqlbt);

                Decimal totalprice_consume=_billdetail.Price * _billdetail.Days;
                foreach (DataRow row in billtable.Rows)
                {
                    totalprice_consume = Convert.ToDecimal(row["totalprice_consume"]) + totalprice_consume;
                }
                string sqlbm = "update bill set totalprice_consume='" + totalprice_consume + "'where idnumber='" + _billdetail.Idnumber + "'";
                int gx = DBHelper.ExecuteCommand(sqlbm);
                 if(result==0)
                 {
                      MessageBox.Show("点单失败");
                 }
                 else
                 {
                      MessageBox.Show("点单成功！");
                 }
            }
        }

        private void btnTui_Click(object sender, EventArgs e)
        {
            if (this.txtIdnum.Text==String.Empty||this.txtQuantity.Text==String.Empty||this.labelDmenu.Text==string.Empty||this.labelDprice.Text==string.Empty)
            {
                MessageBox.Show("请选择商品并填写数量和证件号并选择商品！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToInt32(this.txtQuantity.Text.Trim()) < 0)
            {
                MessageBox.Show("数量不能小于1", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
 
            }
            int result = BillManager.check(this.txtIdnum.Text);
            if (result == 0)
            {
                MessageBox.Show("抱歉，没有该用户！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                billdetail _billdetail = new billdetail();
                _billdetail.Idnumber = this.txtIdnum.Text.Trim();
                _billdetail.Projectnumber = this.labelDmenu.Text.Trim();
                _billdetail.Price = Convert.ToDecimal(this.labelDprice.Text.Trim());
                _billdetail.Days = -Convert.ToInt32(this.txtQuantity.Text.Trim());
                result = BilldetailManager.AddBillDetail(_billdetail);
                string sqlbt = "select * from bill where mark='0' and idnumber=" + "'" + _billdetail.Idnumber + "'";
                DataTable billtable = DBHelper.GetDataSet(sqlbt);

                Decimal totalprice_consume = _billdetail.Price * _billdetail.Days;
                foreach (DataRow row in billtable.Rows)
                {
                    totalprice_consume = Convert.ToDecimal(row["totalprice_consume"]) + totalprice_consume;
                }
                string sqlbm = "update bill set totalprice_consume='" + totalprice_consume + "'where idnumber='" + _billdetail.Idnumber + "'";
                int gx = DBHelper.ExecuteCommand(sqlbm);
                 if(result==0)
                 {
                      MessageBox.Show("退点失败");
                 }
                 else
                 {
                      MessageBox.Show("退点成功！");
                 }
            }
        }

        private void btnYu_Click(object sender, EventArgs e)
        {
            if (this.txtIdnum.Text == String.Empty || this.txtQuantity.Text == String.Empty || this.labelDmenu.Text == string.Empty || this.labelDprice.Text == string.Empty)
            {
                MessageBox.Show("请选择商品并填写数量和证件号并选择商品！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToInt32(this.txtQuantity.Text.Trim()) < 0)
            {
                MessageBox.Show("数量不能小于1", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            int result = BillManager.check(this.txtIdnum.Text);
            if (result == 0)
            {
                MessageBox.Show("请先开单再定单！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                billdetail _billdetail = new billdetail();
                _billdetail.Idnumber = this.txtIdnum.Text.Trim();
                _billdetail.Projectnumber = this.labelDmenu.Text.Trim();
                _billdetail.Price = Convert.ToDecimal(this.labelDprice.Text.Trim());
                _billdetail.Days = Convert.ToInt32(this.txtQuantity.Text.Trim());
                _billdetail.Mark = 0;
                result = BilldetailManager.AddBillDetail(_billdetail);

                string sqlbt = "select * from bill where mark='0' and idnumber=" + "'" + _billdetail.Idnumber + "'";
                DataTable billtable = DBHelper.GetDataSet(sqlbt);

                Decimal totalprice_consume = _billdetail.Price * _billdetail.Days;
                foreach (DataRow row in billtable.Rows)
                {
                    totalprice_consume = Convert.ToDecimal(row["totalprice_consume"]) + totalprice_consume;
                }
                string sqlbm = "update bill set totalprice_consume='" + totalprice_consume + "'where idnumber='" + _billdetail.Idnumber + "'";
                int gx = DBHelper.ExecuteCommand(sqlbm);
                if (result == 0)
                {
                    MessageBox.Show("预定失败");
                }
                else
                {
                    MessageBox.Show("预定成功！");
                }
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            string a = this.tabControl1.SelectedTab.Text;
            if (a == "餐饮基本信息")
            {
                if (主界面.AdType == "收银员")
                {
                    MessageBox.Show("抱歉，您没有权限查看此项！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    this.tabControl1.SelectedTab = this.tabPage2;
                }
            }
        }
        

     
    }
}
