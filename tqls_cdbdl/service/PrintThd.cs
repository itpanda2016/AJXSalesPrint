using tqls_cdbdl.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tqls_cdbdl.db;
using System.Data.Common;

namespace tqls_cdbdl.service
{
    public class PrintThd
    {
        public static int top = 20;
        public static int hjj = 20;//行间距
        public  DataTable data_m;
        public  DataTable data_d;
        public PrintThd(DataTable data_m, DataTable data_d)
        {
            this.data_m = data_m;
            this.data_d = data_d;
        }
        
        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 35;
            int y = PrintThd.top+30;

            DataRow dr = data_m.Rows[0];

            //e.PageSettings.PaperSize.Kind = System.Drawing.Printing.PaperKind.Custom;
            //e.PageSettings.PaperSize.Height = 1000;

            Graphics g = e.Graphics;
            //e.HasMorePages = true;
            //y = 770 * i;
            //绘制表格基本信息
            Font font = new Font("宋体", 10, FontStyle.Regular);
            DbHelper db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond("select dwmc from h_yhdwzc");
            string ret = db.ExecuteScalar(cmd).ToString().Trim();
            //g.DrawString("成都搏大利农牧有限责任公司提货单", new Font("宋体", 16, FontStyle.Bold), Brushes.Black, x + 130, y - 40);
            g.DrawString(ret + "提货单", new Font("宋体", 16, FontStyle.Bold), Brushes.Black, x + 130, y - 40);
            
            g.DrawString(dr["ckmc"].ToString()+"   提货单号:" + dr["sgdh"].ToString(), font, Brushes.Black, x + 30, y-8 );            
            g.DrawString("销售:" + dr["djbh"].ToString(), font, Brushes.Black, x + 300, y-8);

            y += 10;
            g.DrawString("购货单位:" + dr["bh"]+"_"+dr["xm"]+dr["dz"], font, Brushes.Black, x + 30, y);
            g.DrawString("日期:" + dr["lrsj2"], font, Brushes.Black, x + 500, y);
            
            int tabletop = y + 20;
            Pen pen = new Pen(Brushes.Black);
            Pen linePen = new Pen(Color.Black, 0.5f);
            g.DrawRectangle(linePen, x + 30, y + 20, x + 600, 20);
            
            g.DrawString("货号",font,Brushes.Black,x+50,y+25);
            g.DrawString("规格", font, Brushes.Black, x + 170, y + 25);
            g.DrawString("件数(包)", font, Brushes.Black, x + 250, y + 25);
            g.DrawString("数量(公斤)", font, Brushes.Black, x + 350, y + 25);
            g.DrawString("金额(元)", font, Brushes.Black, x + 450, y + 25);
            g.DrawString("备注", font, Brushes.Black, x + 570, y + 25);
           // y = y - 10;
            for (int i = 0; i < this.data_d.Rows.Count; i++, y += 20)
            {
                if (i == data_d.Rows.Count - 2)
                {
                    font=new Font("宋体", 10, FontStyle.Bold);
                }
                DataRow dr2=data_d.Rows[i];
                g.DrawRectangle(linePen, x + 30, y + 20, x + 600, 20);

                if(dr2["spbh"].Equals("-1")){
                    continue;
                }
                //string preStr = "博大利-";
                string preStr = "";
                if (dr2["spbh"].ToString().Equals("合计"))
                {
                    preStr = "";
                }
                g.DrawString(preStr + dr2["spbh"] + "", font, Brushes.Black, x + 30, y + 27 + hjj);
                g.DrawString(dr2["gg"]+"", font, Brushes.Black, x + 170, y + 27 + hjj);

                string bs = dr2["bs"] + (dr2["bs"] == null || dr2["bs"].ToString().Equals("")?"":".");
                SizeF sizef = g.MeasureString(bs, font, 150);
                g.DrawString(bs, font, Brushes.Black, x + 230+(120-sizef.Width), y + 27 + hjj);

                string gjs = dr2["gjs"] + (dr2["gjs"] == null || dr2["gjs"].ToString().Equals("") ? "" : ".");
                sizef = g.MeasureString(gjs, font, 50);
                g.DrawString(gjs, font, Brushes.Black, x + 350 + (100 - sizef.Width), y + 27 + hjj);

                sizef = g.MeasureString(dr2["yje"] + "", font, 150);
                g.DrawString(dr2["yje"]+"", font, Brushes.Black, x + 450+(100-sizef.Width), y + 27 + hjj);

                g.DrawString(dr2["zlbz"].Equals("赠料")?"销售一":"", font, Brushes.Black, x + 570, y + 27 + hjj);
                if(i==data_d.Rows.Count-1){
                    g.DrawLine(linePen, x + 150, tabletop, x + 150, y - 100);
                    g.DrawLine(linePen, x + 230, tabletop, x + 230, y + 60);
                    g.DrawLine(linePen, x + 350, tabletop, x + 350, y + 60);
                    g.DrawLine(linePen, x + 450, tabletop, x + 450, y + 60);
                    g.DrawLine(linePen, x + 550, tabletop, x + 550, y + 60);
                }
                                
            }

            //POS(zzfk) 现金（xjfk）
            Decimal pos = Decimal.Parse(dr["zzfk"].ToString());
            Decimal xjfk = Decimal.Parse(dr["xjfk"].ToString());
            Decimal ysje = Decimal.Parse(dr["je"].ToString()) - Decimal.Parse(dr["zkje"].ToString());
            
             
            EcanRMB rmb=new EcanRMB();
            y += hjj;
            g.DrawRectangle(linePen, x + 30, y, x + 600, 20);
            y += hjj;
            g.DrawRectangle(linePen, x + 30, y, x + 600, 20);
            g.DrawLine(linePen, x + 150, tabletop, x + 150, y + 20);
            g.DrawString("应收金额", font, Brushes.Black, x + 30, y+5);
            g.DrawString(rmb.CmycurD(ysje)+"  ￥"+ysje, font, Brushes.Black, x + 150, y+5);
            //y = hjj;

            hjj = 23;
            font = new Font("宋体", 10, FontStyle.Regular);
            g.DrawString("销货单位（盖章有效）", font, Brushes.Black, x + 30, y + 30);
            g.DrawString("开票："+dr["yhmc"].ToString(), font, Brushes.Black, x + 250, y + 30);
            g.DrawString("收款：",font , Brushes.Black, x + 350, y + 30);
            g.DrawString("提货（承运人）：", font, Brushes.Black, x + 450, y + 30);
            y += hjj;
            
            String xjfkStr = xjfk == 0 ? "" : "现金：￥"+xjfk;
            String posStr = pos == 0 ? "" : "POS:￥" + pos;
            g.DrawString(xjfkStr + posStr, font, Brushes.Black, x + 50, y + 30);
            y += hjj;
            //本次己付款
            Decimal yfk=pos+xjfk;
            g.DrawString("本次货款己付：" +rmb.CmycurD(yfk)+" ￥"+yfk , font, Brushes.Black, x + 30, y + 30);
            y += hjj;

            //余款
            Decimal bcqk=Decimal.Parse(dr["bcqk"].ToString());            
            g.DrawString("本次余款：" + (rmb.CmycurD(bcqk)) + "  ￥" + bcqk.ToString(), font, Brushes.Black, x + 30, y + 30);
            y += hjj;
            g.DrawString("温馨提示：禁止公司营销员向客户借取财物，代收、代结货款等，否则由此产生的一切损失自行承担。", font, Brushes.Black, x + 30, y + 30);
            y += hjj;
            g.DrawString("免责声明：成品车辆出厂未盖蓬布，由此造成的损失由本人全部承担。", font, Brushes.Black, x + 30, y + 30);
            y += hjj;
            g.DrawString("签名：                 驾驶证（身份证）号:", font, Brushes.Black, x + 30, y + 30);
            hjj = 20;
        }
        
        public Boolean print()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            //System.Windows.Forms.PrintPreviewDialog ppd = new System.Windows.Forms.PrintPreviewDialog();
            //ppd.PrintPreviewControl.Zoom = 1.0;
            //ppd.Left = 0;
            //ppd.Top = 0;
            //ppd.Width = 1000;
            //ppd.Height=600;            
            // ppd.Document = pd;

            //ppd.ShowDialog();

            //PaperSize ps = new PaperSize("xinrui", 200, 80);
            //ps.RawKind = 256;//此处是关键。需要指定一个未被占用的值，建议256及以上。
            //pd.DefaultPageSettings.PaperSize = ps;

            //pd.DefaultPageSettings.PaperSize.Kind = System.Drawing.Printing.PaperKind.A2;
            try
            {
                pd.Print();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
            return true;
        }
    }
}
