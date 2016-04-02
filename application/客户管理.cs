using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace 三角湖度假村管理系统
{
    public partial class 客户管理 : Form
    {
        //SqlDataAdapter da;
        //DataSet ds = new DataSet();

        public 客户管理()
        {
            InitializeComponent();
        }
        //隐藏编辑区
        public void HideEditSection()
        {
            this.Height = 417;
            //将编辑区设为不可操作的状态
            this.txtName.Enabled = false;
            this.cboSex.Enabled = false;
            this.txtIdnumber.Enabled = false;
            this.txtPhone.Enabled = false;
            this.txtAddress.Enabled = false;
            this.txtPwd.Enabled = false;

        }
        //显示编辑区
        public void VisibleEditSection()
        {
            this.Height = 417;
            this.txtName.Enabled = true;
            this.cboSex.Enabled = true;
            this.txtIdnumber.Enabled = true;
            this.txtPhone.Enabled = true;
            this.txtAddress.Enabled = true;
            this.txtPwd.Enabled = true;
        }
        //清空编辑区
        public void ClearEditSection()
        {
            this.txtName.Text = "";
            this.txtIdnumber.Text = "";
            this.cboSex.Text = "男";
            this.txtPhone.Text = "";
            this.txtAddress.Text = "";
            this.txtPwd.Text = "";
        }

        //绑定客户信息
        public void BindKehuList()
        {
            if (string.IsNullOrEmpty(this.txtIdentify.Text.Trim()))
            {
                this.dgv_vip.DataSource = KehuManager.GetAllKehu();
            }
            else
                this.dgv_vip.DataSource = KehuManager.GetKehuListByKehu_id(this.txtIdentify.Text.Trim());
        }
        //窗体加载时执行
        private void 客户管理_Load(object sender, EventArgs e)
        {
            BindKehuList();
        }

        private void dgv_vip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String idnumber = dgv_vip.Rows[e.RowIndex].Cells["idnumber"].Value.ToString();
            Kehu _kehu = KehuManager.GetKehuByKehu_id(idnumber);
            this.txtIdnumber.Text = _kehu.Idnumber.Trim();
            this.txtName.Text = _kehu.Name.Trim();
            this.cboSex.Text = _kehu.Sex.Trim();
            this.txtPhone.Text = _kehu.Phone.Trim();
            this.txtAddress.Text = _kehu.Address.Trim();
            this.txtPwd.Text = _kehu.Pwd.Trim();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //通过客户身份证号得到客户列表
                BindKehuList();
                if (this.dgv_vip.DataSource == null)
                {
                    MessageBox.Show("抱歉，没有这个客户！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    String idnumber = this.dgv_vip.Rows[0].Cells["idnumber"].Value.ToString();
                    Kehu _kehu = KehuManager.GetKehuByKehu_id(idnumber);
                    this.txtName.Text = _kehu.Name.Trim();
                    this.cboSex.Text = _kehu.Sex.Trim();
                    this.txtIdnumber.Text = _kehu.Idnumber.Trim();
                    this.txtPhone.Text = _kehu.Phone.Trim();
                    this.txtAddress.Text = _kehu.Address.Trim();
                    this.txtPwd.Text = _kehu.Pwd.Trim();
                }
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ClearEditSection();
                this.txtIdnumber2.Text = "";
                this.dgvCustomer.DataSource = null;
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgv_vip.SelectedRows.Count == 0)
                {
                    MessageBox.Show("请先单击每行最左边选择要删除的行！");
                }
                else
                {
                    String idnumber = this.dgv_vip.CurrentRow.Cells[3].Value.ToString();
                    if (MessageBox.Show("确定删除此客户信息吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int result = KehuManager.DeleteKehuByKehu_id(idnumber);
                        if (result == 1)
                        {
                            MessageBox.Show(string.Format("已删除{0}客户信息！", idnumber));
                            BindKehuList();
                        }
                        else
                        {
                            MessageBox.Show("删除失败，请重新操作！");
                        }
                    }
                }
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == string.Empty || cboSex.Text == string.Empty || txtIdnumber.Text == string.Empty ||
                    txtPhone.Text == string.Empty || txtPwd.Text == string.Empty)
                {
                    MessageBox.Show("请输入完整的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                String idnumber = this.dgv_vip.Rows[0].Cells["idnumber"].Value.ToString();
                Kehu _kehu = KehuManager.GetKehuByKehu_id(idnumber);
                _kehu.Name = this.txtName.Text.Trim();
                _kehu.Sex = this.cboSex.Text.Trim();
                _kehu.Phone = this.txtPhone.Text.Trim();
                _kehu.Address = this.txtAddress.Text.Trim();
                _kehu.Pwd = this.txtPwd.Text.Trim();
                bool result = KehuManager.ModifyKehu(_kehu);
                if (result)
                {
                    BindKehuList();
                    MessageBox.Show("修改成功！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("修改出错，请重新操作！");
                }
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == string.Empty || cboSex.Text == string.Empty || txtIdnumber.Text == string.Empty ||
                    txtPhone.Text == string.Empty || txtPwd.Text == string.Empty)
                {
                    MessageBox.Show("请输入完整的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Kehu _kehu = new Kehu();
                _kehu.Idnumber = this.txtIdnumber.Text.Trim();
                _kehu.Name = this.txtName.Text.Trim();
                _kehu.Sex = this.cboSex.Text.Trim();
                _kehu.Phone = this.txtPhone.Text.Trim();
                _kehu.Address = this.txtAddress.Text.Trim();
                _kehu.Pwd = this.txtPwd.Text.Trim();
                int message = KehuManager.AddKehu(_kehu);
                if (message == 0)
                {
                    MessageBox.Show("客户已存在！");
                }
                else
                {
                    BindKehuList();
                    MessageBox.Show("添加成功！");
                }
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            try
            {                
                String idnumber = this.txtIdnumber2.Text;
                string sql = "select * from customer where idnumber=" + "'" + idnumber + "' or name=" + "'" + idnumber + "'";
                this.dgvCustomer.DataSource = DBHelper.GetDataSet(sql) ;
            }
            catch (Exception ex)//抛出异常            
            {
                MessageBox.Show(ex.Message);//弹出消息对话框            
            }
        }

        private void 客户管理_Load_1(object sender, EventArgs e)
        {

        }
    }
}
