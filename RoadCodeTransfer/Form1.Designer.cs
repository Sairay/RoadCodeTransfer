namespace RoadCodeTransfer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.receive_detail_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.receive_listView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rec_ipBox1 = new RoadCodeTransfer.IpBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connect_btn = new System.Windows.Forms.Button();
            this.rec_port_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.send_ipBox2 = new RoadCodeTransfer.IpBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.send_cmd_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.add_to_list_btn = new System.Windows.Forms.Button();
            this.send_port_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.send_listview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.commandsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(499, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.editToolStripMenuItem.Text = "发送";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.configureToolStripMenuItem.Text = "接收";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.commandsToolStripMenuItem.Text = "设置";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.helpToolStripMenuItem.Text = "帮助";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 518);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.receive_detail_textBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.receive_listView);
            this.tabPage1.Controls.Add(this.rec_ipBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.connect_btn);
            this.tabPage1.Controls.Add(this.rec_port_textbox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "接收";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // receive_detail_textBox
            // 
            this.receive_detail_textBox.Location = new System.Drawing.Point(10, 408);
            this.receive_detail_textBox.Multiline = true;
            this.receive_detail_textBox.Name = "receive_detail_textBox";
            this.receive_detail_textBox.ReadOnly = true;
            this.receive_detail_textBox.Size = new System.Drawing.Size(473, 68);
            this.receive_detail_textBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "详细命令内容";
            // 
            // receive_listView
            // 
            this.receive_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.receive_listView.GridLines = true;
            this.receive_listView.Location = new System.Drawing.Point(10, 139);
            this.receive_listView.Name = "receive_listView";
            this.receive_listView.Size = new System.Drawing.Size(473, 234);
            this.receive_listView.TabIndex = 7;
            this.receive_listView.UseCompatibleStateImageBehavior = false;
            this.receive_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "接收时间";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "命令内容";
            this.columnHeader4.Width = 250;
            // 
            // rec_ipBox1
            // 
            this.rec_ipBox1.Location = new System.Drawing.Point(103, 17);
            this.rec_ipBox1.Name = "rec_ipBox1";
            this.rec_ipBox1.Size = new System.Drawing.Size(136, 20);
            this.rec_ipBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "接收命令内容：";
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(78, 53);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(342, 27);
            this.connect_btn.TabIndex = 6;
            this.connect_btn.Text = "连接并接收命令";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // rec_port_textbox
            // 
            this.rec_port_textbox.Location = new System.Drawing.Point(333, 17);
            this.rec_port_textbox.MaxLength = 10;
            this.rec_port_textbox.Name = "rec_port_textbox";
            this.rec_port_textbox.Size = new System.Drawing.Size(71, 21);
            this.rec_port_textbox.TabIndex = 5;
            this.rec_port_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rec_port_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "接收 IP 地址：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.send_ipBox2);
            this.tabPage2.Controls.Add(this.send_btn);
            this.tabPage2.Controls.Add(this.send_cmd_box);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.add_to_list_btn);
            this.tabPage2.Controls.Add(this.send_port_box);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.send_listview);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(489, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "发送";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // send_ipBox2
            // 
            this.send_ipBox2.Location = new System.Drawing.Point(91, 15);
            this.send_ipBox2.Name = "send_ipBox2";
            this.send_ipBox2.Size = new System.Drawing.Size(136, 20);
            this.send_ipBox2.TabIndex = 3;
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(398, 411);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 23);
            this.send_btn.TabIndex = 6;
            this.send_btn.Text = "发送";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // send_cmd_box
            // 
            this.send_cmd_box.Location = new System.Drawing.Point(12, 280);
            this.send_cmd_box.Multiline = true;
            this.send_cmd_box.Name = "send_cmd_box";
            this.send_cmd_box.Size = new System.Drawing.Size(471, 125);
            this.send_cmd_box.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "发送内容：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "发送IP列表：";
            // 
            // add_to_list_btn
            // 
            this.add_to_list_btn.Location = new System.Drawing.Point(398, 15);
            this.add_to_list_btn.Name = "add_to_list_btn";
            this.add_to_list_btn.Size = new System.Drawing.Size(75, 23);
            this.add_to_list_btn.TabIndex = 5;
            this.add_to_list_btn.Text = "添加到列表";
            this.add_to_list_btn.UseVisualStyleBackColor = true;
            this.add_to_list_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // send_port_box
            // 
            this.send_port_box.Location = new System.Drawing.Point(311, 15);
            this.send_port_box.MaxLength = 10;
            this.send_port_box.Name = "send_port_box";
            this.send_port_box.Size = new System.Drawing.Size(64, 21);
            this.send_port_box.TabIndex = 4;
            this.send_port_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.port_keyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "端口号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "发送IP地址：";
            // 
            // send_listview
            // 
            this.send_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.send_listview.GridLines = true;
            this.send_listview.HideSelection = false;
            this.send_listview.Location = new System.Drawing.Point(6, 82);
            this.send_listview.Name = "send_listview";
            this.send_listview.Size = new System.Drawing.Size(477, 151);
            this.send_listview.TabIndex = 0;
            this.send_listview.UseCompatibleStateImageBehavior = false;
            this.send_listview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP地址";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "端口";
            this.columnHeader2.Width = 120;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel,
            this.progressbar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(499, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslabel
            // 
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(41, 17);
            this.statuslabel.Text = "未连接";
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(150, 16);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 570);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "RoadCode";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.TextBox rec_port_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_to_list_btn;
        private System.Windows.Forms.TextBox send_port_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView send_listview;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.TextBox send_cmd_box;
        private System.Windows.Forms.Label label7;
        private IpBox rec_ipBox1;
        private IpBox send_ipBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView receive_listView;
        private System.Windows.Forms.TextBox receive_detail_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

