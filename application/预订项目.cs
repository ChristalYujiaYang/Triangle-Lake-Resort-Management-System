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
    public partial class 预订项目 : Form
    {

        public static string project;
        public string IdNum;//客户id
        public string CName;//客户姓名
        public string Pn;//客户电话
        public int Dy;//预定天数
        // public int Hr;//预定小时
        public int Lv = 1;//会员等级
        public double discount;//打折率
        public double totalprice_consume;//客户消费总额
        public string sex;
        public DataTable gettable;
        /// <summary>
        /// 
        /// </summary>
        //得到预定房间的信息
        private void GetTable(string _project)
        {
            if (_project.Substring(0, 2) == "RM")
            {
                gettable = RoomManager.GetRoomTableByRoom_num(_project);
                this.txtday.Text = "1";
            }
            else if (_project.Substring(0, 2) == "MT")
            {
                gettable = PlaceManager.GetMeetingroomByMeeting_num(_project);
                this.txtday.Text = "1";

            }
            else if (_project.Substring(0, 2) == "TB")
            {
                gettable = PlaceManager.GetTabletennisByTable_num(_project);
                this.txtday.Text = "1";
            }
            else if (_project.Substring(0, 2) == "CR")
            {
                gettable = PlaceManager.GetChessroomByChess_num(_project);
                this.txtday.Text = "1";

            }

        }
        //修改预定房间的信息
        private void Modefiy(string _project)
        {
            string xx = "";
            if (_project.Substring(0, 2) == "RM")
            {
                xx = "update room set status='预订' where room_num='" + _project + "'";
            }
            else if (_project.Substring(0, 2) == "MT")
            {
                xx = "update meetingroom set status='预订' where meetingnumber='" + _project + "'";
            }
            else if (_project.Substring(0, 2) == "TB")
            {
                xx = "update tabletennis set status='预订' where tablenumber='" + _project + "'";
            }
            else if (_project.Substring(0, 2) == "CR")
            {
                xx = "update chessroom set status='预订' where chessnumber='" + _project + "'";
            }
            DBHelper.ExecuteCommand(xx);

        }
        //查询客户是否为vip
        private void checkvip(string idnum)
        {
            string sqlv = "select * from vip where idnumber=" + "'" + idnum + "'";
            int i = DBHelper.GetScalar(sqlv);
            if (i != 0)
            {
                DataTable viptable = DBHelper.GetDataSet(sqlv);
                foreach (DataRow row in viptable.Rows)
                {
                    Lv = Convert.ToInt32(row["level"]);
                }
                if (Lv == 1)
                { discount = 1; }
                else if (Lv == 2)
                {
                    discount = 0.95;
                }
                else if (Lv == 3)
                {
                    discount = 0.90;
                }
                else if (Lv == 4)
                {
                    discount = 0.85;
                }
                else
                {
                    discount = 0.80;
                }

            }
            else
            {
                discount = 1;
            }
        }
        //查询客户是否开单
        private int checkbill(string idnum)
        {
            string sqlb = "select * from bill where mark='0' and idnumber=" + "'" + idnum + "'";
            int i = DBHelper.GetScalar(sqlb);
            return i;
        }
        //查看客户是否已经预定
        private int checkorder(string idnum)
        {
            string sqlb = "select * from [order] where idnumber=" + "'" + idnum + "'";
            int i = DBHelper.GetScalar(sqlb);
            return i;
        }

        public 预订项目(string projectnumber, string item)
        {
            try
            {
                InitializeComponent();
                this.labProject.Text =item;
                this.labProjectNum.Text = projectnumber; 
                this.txtday.Text = "0";
                project = projectnumber;
                
                GetTable(project);
                foreach (DataRow row in gettable.Rows)
                {
                    if (Convert.ToString(row["status"]) != "空闲")
                    {
                        MessageBox.Show("房间不可预定，请按取消关闭窗口！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        this.labProjectP.Text = Convert.ToString(row["price"]);
                    }
                }
            }
            catch (Exception ex)//抛出异常????????????
            {
                MessageBox.Show(ex.Message);//弹出消息对话框????????????
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        //确认按钮
        private void button6_Click(object sender, EventArgs e)
        {
            if (this.txtNum.Text.Length < 18 || this.txtNum.Text.Length > 20 )
            {
                MessageBox.Show("身份证输入错误！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.txtName.Text == "" || this.txtPn.Text == "" || this.CboSex.Text == "")
            {
                MessageBox.Show("请填写完整！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    IdNum = this.txtNum.Text.Trim();
                    CName = this.txtName.Text.Trim();
                    Pn = this.txtPn.Text.Trim();
                    sex = this.CboSex.Text;
                    checkvip(IdNum);
                    int k = checkbill(IdNum);
                    //计算客户本次预定总价

                    totalprice_consume = Convert.ToDouble(this.labProjectP.Text.Trim()) * Lv * Convert.ToInt32(this.txtday.Text.Trim());

                    if (k != 0)//客户已经开单
                    {
                        if (MessageBox.Show("确认预定？", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            string sqlbt = "select * from bill where mark='0' and idnumber=" + "'" + IdNum + "'";
                            DataTable billtable = DBHelper.GetDataSet(sqlbt);

                            foreach (DataRow row in billtable.Rows)
                            {
                                // string a = Convert.ToString(row["totalprice_consume"]);
                                //MessageBox.Show(string.Format("已删除{0} 房间信息！", a));
                                totalprice_consume = Convert.ToDouble(row["totalprice_consume"]) + totalprice_consume;
                            }
                            //更新数据bill表
                            string sqlbm = "update bill set totalprice_consume='" + totalprice_consume + "'where idnumber='" + IdNum + "'";
                            int gx = DBHelper.ExecuteCommand(sqlbm);
                            //插入到billdetail
                            string sqlbd = "insert into billdetail(idnumber,projectnumber,price,days,discount,discountprice,mark) values ('" + IdNum + "','" + project + "','" + Convert.ToDouble(this.labProjectP.Text.Trim()) + "','" + Convert.ToInt32(this.txtday.Text.Trim()) + "','" + Lv + "','" + Convert.ToDouble(this.labProjectP.Text.Trim()) * Lv + "','0')";
                            int xr = DBHelper.GetScalar(sqlbd);
                            Modefiy(project);//修改房间状
                            MessageBox.Show("预定成功！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else { return; }
                    }
                    else //客户未开单
                    {
                        int checko = checkorder(IdNum);
                        if (checko != 0)//客户已经预定
                        {
                            if (MessageBox.Show("确认预定？", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                string sqlot = "select * from [order] where idnumber=" + "'" + IdNum + "'";
                                DataTable ordertable = DBHelper.GetDataSet(sqlot);


                                foreach (DataRow row in ordertable.Rows)
                                {
                                    totalprice_consume = Convert.ToDouble(row["totalprice"]) + totalprice_consume;
                                }
                                //更新数据order表
                                string sqlbm = "update [order] set totalprice='" + totalprice_consume + "'where idnumber='" + IdNum + "'";
                                int gx = DBHelper.ExecuteCommand(sqlbm);
                                //插入到orderdetail
                                string sqlod = "insert into orderdetail(price,days,discount,discountprice,idnumber,projectnumber) values ('" + Convert.ToDouble(this.labProjectP.Text.Trim()) + "','" + Convert.ToInt32(this.txtday.Text.Trim()) + "','" + Lv + "','" + Convert.ToDouble(this.labProjectP.Text.Trim()) * Lv + "','" + IdNum + "','" + project + "')";
                                int xr = DBHelper.GetScalar(sqlod);
                                Modefiy(project);//修改房间状态

                                MessageBox.Show("预定成功！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else { return; }

                        }
                        else //客户未预订预定
                        {
                            if (MessageBox.Show("确认预定？", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                string sqlc = "select *from customer where idnumber= '" + IdNum + "'";
                                int xc = DBHelper.GetScalar(sqlc);
                                if (xc == 0)
                                {
                                    string sqlcx = "insert into customer(name,idnumber,phonenumber,sex)values('" + CName + "','" + IdNum + "','" + Pn + "','" + sex + "')";
                                    DBHelper.GetScalar(sqlcx);
                                }

                                string sqloa = "insert into [order](customername,idnumber,totalprice,date,phonenumber)values('" + CName + "','" + IdNum + "','" + totalprice_consume + "','" + this.dateTimePicker1.Value + "','" + this.txtPn.Text.Trim() + "')";
                                int xr = DBHelper.GetScalar(sqloa);
                                string sqlod = "insert into orderdetail(price,days,discount,discountprice,idnumber,projectnumber) values ('" + Convert.ToDouble(this.labProjectP.Text.Trim()) + "','" + Convert.ToInt32(this.txtday.Text.Trim()) + "','" + Lv + "','" + Convert.ToDouble(this.labProjectP.Text.Trim()) * Lv + "','" + IdNum + "','" + project + "')";
                                int xr1 = DBHelper.GetScalar(sqlod);
                                // MessageBox.Show(string.Format("已删除{0} {1}房间信息！", xr,xr1));
                                Modefiy(project);//修改房间状态

                                MessageBox.Show("预定成功！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else { return; }
                        }
                    }

                }
                catch (Exception ex)//抛出异常????????????
                {
                    MessageBox.Show(ex.Message);//弹出消息对话框????????????
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 预订项目_Load(object sender, EventArgs e)
        {

        }

    }
}
