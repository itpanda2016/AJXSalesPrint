using tqls_cdbdl.db;
using tqls_cdbdl.service;
using tqls_cdbdl.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tqls_cdbdl
{
    public partial class Form1 : Form
    {

        DataTable data_m;
        DataTable data_d;
        EcanRMB rmb = new EcanRMB();
        public Form1()
        {
            InitializeComponent();
            lbl_thdh.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.dataGridView1.AutoGenerateColumns = false;
            //Test db=new Test();
            //this.dataGridView1.DataSource = db.test().Tables[0];
            DbHelper db=new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond("select djbh from tu_xskpd_m where lrsj=(select max(lrsj) from tu_xskpd_m where shzt='已审核')");
            string dh=db.ExecuteScalar(cmd).ToString();
            //string dh = "FK00000001";
            this.txt_djbh.Text = dh;
            textBox1_TextChanged(this.txt_djbh, e);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DbHelper db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond("select c.*,z.gg gg from ( "+
                                        " select xh,djbh,spbh,gjj,CEILING(gjs) gjs,CEILING(bs) bs,jgc,"+
                                        " cast(round(yje,2) as numeric(10,2))  yje,"+
                                        " cast(round(je,2) as numeric(10,2))  je,"+
                                        " zlbz "+
                                        " from tu_xskpd_d where djbh='" + this.txt_djbh.Text.Trim() + "'" +
                                        " ) c left join tu_spzc z on c.spbh=z.spbh" +
                                        " order by xh");
            DataTable tb = db.ExecuteDataTable(cmd);
            if (tb.Rows.Count <= 0)
            {
                lbl_msg.Text  = "未查询到数据";
                return;
            }
            else
            {
                lbl_msg.Text = "";
            }
            String sql ="select cast(year(m.lrsj) as varchar(10)) + '年' "+
                        "+ cast(month(m.lrsj) as varchar(10)) + '月' "+
                        "+ cast(day(m.lrsj) as varchar(10)) + '日'"+
                        " lrsj2, "+
                        "c.zbs,c.zgjs,u.yhmc,k.bh,k.xm,k.dz,m.*  "+
                        "from tu_xskpd_m m left join tu_khzc k  "+
                        "on m.khbh=k.bh left join tp_yhzc u "+
                        "on m.lrybh=u.yhbh left join ( select djbh,sum(bs) zbs,sum(gjs) zgjs from tu_xskpd_d group by djbh ) c on m.djbh=c.djbh  " +
                        "where m.djbh='"+this.txt_djbh.Text.Trim()+"' and m.shzt='已审核'";
            // //" where m.djbh='" +  + "'" +
            // " ";
            cmd = db.GetSqlStringCommond(sql);
            DataTable table = db.ExecuteDataTable(cmd);
            this.lbl_thdh.Text = table.Rows[0]["sgdh"].ToString();


            DataRow dr = tb.NewRow();
            dr["spbh"] = "折扣";
            dr["yje"] = "-"+table.Rows[0]["zkje"].ToString(); ;
            tb.Rows.Add(dr);

            for (int i = 0; i < 11 - tb.Rows.Count;i++ )
            {
                dr = tb.NewRow();
                dr["spbh"] = "-1";
                dr["yje"] = 0;
                dr["bs"] = 0;
                dr["gjs"] = 0; 
                tb.Rows.Add(dr);
            }

            //合计计算  je-zkje
            Decimal je = Decimal.Parse(table.Rows[0]["je"].ToString());
            Decimal zkje = Decimal.Parse(table.Rows[0]["zkje"].ToString());
            Decimal ysje = je - zkje;
            string zbs=table.Rows[0]["zbs"].ToString();
            string gjs=table.Rows[0]["zgjs"].ToString();
            dr = tb.NewRow();
            dr["spbh"] = "合计";
            dr["yje"] = ysje;
            dr["bs"] = zbs.Substring(0,zbs.LastIndexOf("."));
            dr["gjs"] = gjs.Substring(0, gjs.LastIndexOf("."));
            tb.Rows.Add(dr);

            data_m = table;
            data_d = tb;
            this.dataGridView1.DataSource = tb;
            this.lbl_ysje.Text = rmb.CmycurD(ysje) + " ￥" + ysje;
            //this.btn_print_Click(sender,e);


        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintThd print = new PrintThd(data_m, data_d);
            if (data_d==null)
            {
                MessageBox.Show("未找到数据");                    
                return;
            }
            else
            {
                print.print();
            }
            //Form2 f2 = new Form2();
            //f2.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.Show();
        }

        private void 显示主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            string t=this.txt_p1.Text.Trim();
            string t2 = Encrypt.EncodeBase64(t);
            string aa = "U2VydmVyPTEwLjIuOS4yMDE7RGF0YUJhc2U9YWp4YmRsO1VpZD1zYTtwd2Q9Y2RiZGw7";
            this.txt_p2.Text = Encrypt.DecodeBase64(aa);
        }
    }
}
