namespace tqls_cdbdl
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spbh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gjs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zlbz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_djbh = new System.Windows.Forms.TextBox();
            this.lbl_thdh = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.lbl_thdh_ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ysje = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menu_Main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spbh,
            this.xh,
            this.bs,
            this.gjs,
            this.yje,
            this.zlbz});
            this.dataGridView1.Location = new System.Drawing.Point(31, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(648, 315);
            this.dataGridView1.TabIndex = 1;
            // 
            // spbh
            // 
            this.spbh.DataPropertyName = "spbh";
            this.spbh.HeaderText = "货号";
            this.spbh.Name = "spbh";
            // 
            // xh
            // 
            this.xh.DataPropertyName = "xh";
            this.xh.HeaderText = "规格";
            this.xh.Name = "xh";
            // 
            // bs
            // 
            this.bs.DataPropertyName = "bs";
            this.bs.HeaderText = "件数（包）";
            this.bs.Name = "bs";
            // 
            // gjs
            // 
            this.gjs.DataPropertyName = "gjs";
            this.gjs.HeaderText = "数量（公斤）";
            this.gjs.Name = "gjs";
            // 
            // yje
            // 
            this.yje.DataPropertyName = "yje";
            this.yje.HeaderText = "金额（元）";
            this.yje.Name = "yje";
            // 
            // zlbz
            // 
            this.zlbz.DataPropertyName = "zlbz";
            this.zlbz.HeaderText = "备注";
            this.zlbz.Name = "zlbz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(202, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "销售";
            // 
            // txt_djbh
            // 
            this.txt_djbh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_djbh.Location = new System.Drawing.Point(250, 24);
            this.txt_djbh.Name = "txt_djbh";
            this.txt_djbh.Size = new System.Drawing.Size(166, 21);
            this.txt_djbh.TabIndex = 3;
            this.txt_djbh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_thdh
            // 
            this.lbl_thdh.AutoSize = true;
            this.lbl_thdh.Location = new System.Drawing.Point(154, 30);
            this.lbl_thdh.Name = "lbl_thdh";
            this.lbl_thdh.Size = new System.Drawing.Size(11, 12);
            this.lbl_thdh.TabIndex = 5;
            this.lbl_thdh.Text = "T";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(436, 25);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 6;
            this.btn_print.Text = "打印";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // lbl_thdh_
            // 
            this.lbl_thdh_.AutoSize = true;
            this.lbl_thdh_.Location = new System.Drawing.Point(95, 30);
            this.lbl_thdh_.Name = "lbl_thdh_";
            this.lbl_thdh_.Size = new System.Drawing.Size(53, 12);
            this.lbl_thdh_.TabIndex = 4;
            this.lbl_thdh_.Text = "提货单号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "购货单位:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "日期:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "成品库";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "应收金额";
            // 
            // lbl_ysje
            // 
            this.lbl_ysje.AutoSize = true;
            this.lbl_ysje.Location = new System.Drawing.Point(97, 400);
            this.lbl_ysje.Name = "lbl_ysje";
            this.lbl_ysje.Size = new System.Drawing.Size(41, 12);
            this.lbl_ysje.TabIndex = 11;
            this.lbl_ysje.Text = "label6";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.menu_Main;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "铁骑力士打印";
            this.notifyIcon1.Visible = true;
            // 
            // menu_Main
            // 
            this.menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主界面ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menu_Main.Name = "menu_Main";
            this.menu_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu_Main.Size = new System.Drawing.Size(137, 48);
            this.menu_Main.Text = "显示主界面";
            // 
            // 显示主界面ToolStripMenuItem
            // 
            this.显示主界面ToolStripMenuItem.Name = "显示主界面ToolStripMenuItem";
            this.显示主界面ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.显示主界面ToolStripMenuItem.Text = "显示主界面";
            this.显示主界面ToolStripMenuItem.Click += new System.EventHandler(this.显示主界面ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem1.Text = "退出系统";
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.ForeColor = System.Drawing.Color.Red;
            this.lbl_msg.Location = new System.Drawing.Point(518, 29);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 12);
            this.lbl_msg.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_p2);
            this.panel1.Controls.Add(this.btn_encrypt);
            this.panel1.Controls.Add(this.txt_p1);
            this.panel1.Location = new System.Drawing.Point(387, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 67);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(12, 33);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(166, 21);
            this.txt_p2.TabIndex = 2;
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(201, 22);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_encrypt.TabIndex = 1;
            this.btn_encrypt.Text = "button1";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(12, 7);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(166, 21);
            this.txt_p1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.lbl_ysje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.lbl_thdh);
            this.Controls.Add(this.lbl_thdh_);
            this.Controls.Add(this.txt_djbh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "打印插件";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menu_Main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_djbh;
        private System.Windows.Forms.DataGridViewTextBoxColumn spbh;
        private System.Windows.Forms.DataGridViewTextBoxColumn xh;
        private System.Windows.Forms.DataGridViewTextBoxColumn bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn gjs;
        private System.Windows.Forms.DataGridViewTextBoxColumn yje;
        private System.Windows.Forms.DataGridViewTextBoxColumn zlbz;
        private System.Windows.Forms.Label lbl_thdh;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label lbl_thdh_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ysje;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip menu_Main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 显示主界面ToolStripMenuItem;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_p2;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.TextBox txt_p1;



    }
}

