using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;


namespace RoadCodeTransfer
{
    public partial class Form1 : Form
    {
        private IpAddr rec_ipAddress;
        private List<IpAddr> send_ipAddrList;   

        private SocketUtil sktUtil;

        private bool connecionstate;
        private Socket receive_socket;

        public Form1()
        {
            InitializeComponent();
            rec_ipAddress = new IpAddr();
            send_ipAddrList = new List<IpAddr>();
            sktUtil = new SocketUtil();
            connecionstate = false;

        }
        Thread t;
        private delegate void Forward();

        public void Helper()
        {
            Forward d = new Forward(progressThreading);
            this.Invoke(d);
        }

        public void progressThreading()
        {
            // 设置精度条的最小值为1  
            this.progressbar.Minimum = 1;
            // 设置进度条的最大值为100  
            this.progressbar.Maximum = 500;
            // 设置进度条的初始值为1  
            this.progressbar.Value = 1;
            // 设置每次增长的步骤为10  
            this.progressbar.Step = 10;
            //循环10次 每次增长10 最后正好满了，每增长一次休息300（单位时间）  
            for (int i = 0; i < 10; i++)
            {
                this.progressbar.PerformStep();
                Thread.Sleep(1000);
            }
            t.Abort();//关闭线程  
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.connecionstate == false)
            {
                if (this.rec_ipBox1.Text.Equals(""))
                {
                    MessageBox.Show("请输入接收IP地址!");
                    return;
                }
                this.rec_ipAddress.IpAddrs = this.rec_ipBox1.Text;
                if (this.rec_port_textbox.Text.Equals(""))
                {
                    MessageBox.Show("请输入接收端口号!");
                    return;
                }
                this.rec_ipAddress.Port = this.rec_port_textbox.Text;

                this.statuslabel.Text = "正在连接";

                this.connect_btn.Enabled = false;

                backgroundWorker1.RunWorkerAsync(this.rec_ipAddress);
                
              
            }
            else
            {
                if (receive_socket != null)
                {
                    sktUtil.disConnection(receive_socket);
                    this.connect_btn.Text = "连接并接收命令";
                    this.statuslabel.Text = "未连接";
                    this.rec_ipBox1.Enabled = true;
                    this.rec_port_textbox.Enabled = true;
                    this.connecionstate = false;
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.send_ipBox2.Text.Equals(""))
            {
                MessageBox.Show("请输入发送IP地址!");
                return;
            }
           
            if (this.send_port_box.Text.Equals(""))
            {
                MessageBox.Show("请输入发送端口号!");
                return;
            }
          
            
            IpAddr sendip = new IpAddr();
            sendip.IpAddrs = this.send_ipBox2.Text;
            sendip.Port = this.send_port_box.Text;

            this.send_ipAddrList.Add(sendip);
            this.addToListView(sendip);

            this.send_ipBox2.clearText();
            this.send_port_box.Text = "";
        }

        private void addToListView(IpAddr sendip)
        {
            this.send_listview.BeginUpdate();

            ListViewItem item = new ListViewItem();
            item.Text = sendip.IpAddrs;
            item.SubItems.Add(sendip.Port);

            this.send_listview.Items.Add(item);

            this.send_listview.EndUpdate();
        }

        private void updateListView()
        {
            this.send_listview.BeginUpdate();

            this.send_listview.EndUpdate();
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.send_listview.Items.Count == 0)
            {
                MessageBox.Show("发送列表为空!");
                return;
            }
            if (this.send_cmd_box.Text == "")
            {
                MessageBox.Show("发送命令为空");
                return;
            }

            Form2 form2 = new Form2();
            form2.AllIPList = this.send_ipAddrList;
            form2.message = this.send_cmd_box.Text;
            form2.ShowDialog();
        }

        private void port_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void rec_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            t = new Thread(new ThreadStart(Helper)); //实例化线程  
            t.Start();//启动线程 
            IpAddr ipaddr =(IpAddr)e.Argument;
            receive_socket = sktUtil.getConnection(ipaddr.IpAddrs, ipaddr.Port);
           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
            this.connect_btn.Enabled = true;
            if (receive_socket != null)
            {
                this.rec_ipBox1.Enabled = false;
                this.rec_port_textbox.Enabled = false;
                this.connect_btn.Text = "断开连接";
                this.statuslabel.Text = "已连接就绪";
                this.connecionstate = true;
                this.progressbar.Value = 1;
            }
            else
            {
                MessageBox.Show("与所提供的IP地址和端口号连接错误!");
                this.statuslabel.Text = "未连接";
                this.progressbar.Value = 1;

            }
        }
    }
}
