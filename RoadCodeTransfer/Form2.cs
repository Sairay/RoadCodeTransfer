using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace RoadCodeTransfer
{
    public partial class Form2 : Form
    {
        public List<IpAddr> AllIPList { get; set; }
        public string message { get; set; }

        private List<IpAddr> sendList = new List<IpAddr>();

        public Form2()
        {
            InitializeComponent();           

        }

       
        private void loadList()
        {
            this.All_Send_Addr_listView.BeginUpdate();
            this.All_Send_Addr_listView.Items.Clear();

            if (this.AllIPList != null)
            {
                foreach(IpAddr ip in this.AllIPList){
                    ListViewItem item = new ListViewItem();
                    item.Text = ip.IpAddrs;
                    item.SubItems.Add(ip.Port);
                    this.All_Send_Addr_listView.Items.Add(item);
                }
            }

            this.All_Send_Addr_listView.EndUpdate();
        }

        private void removeFromAllList()
        {
            if (this.All_Send_Addr_listView.SelectedItems.Count > 0)
            {
                ListViewItem item = this.All_Send_Addr_listView.SelectedItems[0];
                IpAddr ip = new IpAddr();
                ip.IpAddrs = item.Text;
                ip.Port = item.SubItems[1].Text;
                this.sendList.Add(ip);
                this.All_Send_Addr_listView.BeginUpdate();
                this.All_Send_Addr_listView.Items.Remove(item);
                this.All_Send_Addr_listView.EndUpdate();

                this.Need_Send_Addr_listView.BeginUpdate();
                ListViewItem nitem = new ListViewItem();
                nitem.Text = ip.IpAddrs;
                nitem.SubItems.Add(ip.Port);
                this.Need_Send_Addr_listView.Items.Add(nitem);

                this.Need_Send_Addr_listView.EndUpdate();

            }
            
        }

        private void removeAllSelectedFromAllList()
        {
            if (this.All_Send_Addr_listView.SelectedItems.Count > 0)
            {
                this.All_Send_Addr_listView.BeginUpdate();
                this.Need_Send_Addr_listView.BeginUpdate();
                foreach (ListViewItem item in this.All_Send_Addr_listView.SelectedItems)
                {
                    IpAddr ip = new IpAddr();
                    ip.IpAddrs = item.Text;
                    ip.Port = item.SubItems[1].Text;
                    this.sendList.Add(ip);
                   
                    this.All_Send_Addr_listView.Items.Remove(item);
                   

                    
                    ListViewItem nitem = new ListViewItem();
                    nitem.Text = ip.IpAddrs;
                    nitem.SubItems.Add(ip.Port);
                    this.Need_Send_Addr_listView.Items.Add(nitem);

                   
                }
                this.All_Send_Addr_listView.EndUpdate();
                this.Need_Send_Addr_listView.EndUpdate();


            }
        }

        private void addToAllList()
        {
            if (this.Need_Send_Addr_listView.SelectedItems.Count > 0)
            {
                ListViewItem item = this.Need_Send_Addr_listView.SelectedItems[0];
                IpAddr ip = new IpAddr();
                ip.IpAddrs = item.Text;
                ip.Port = item.SubItems[1].Text;
                
                this.Need_Send_Addr_listView.BeginUpdate();
                this.Need_Send_Addr_listView.Items.Remove(item);
                this.Need_Send_Addr_listView.EndUpdate();

                this.All_Send_Addr_listView.BeginUpdate();
                ListViewItem nitem = new ListViewItem();
                nitem.Text = ip.IpAddrs;
                nitem.SubItems.Add(ip.Port);
                this.All_Send_Addr_listView.Items.Add(nitem);
                this.All_Send_Addr_listView.EndUpdate();
                this.sendList.Remove(ip);
            }
        }

        private void addAllToAllList()
        {
            if (this.Need_Send_Addr_listView.SelectedItems.Count > 0)
            {
                this.All_Send_Addr_listView.BeginUpdate();
                this.Need_Send_Addr_listView.BeginUpdate();
                foreach (ListViewItem item in this.Need_Send_Addr_listView.SelectedItems)
                {
                    IpAddr ip = new IpAddr();
                    ip.IpAddrs = item.Text;
                    ip.Port = item.SubItems[1].Text;
                   

                    this.Need_Send_Addr_listView.Items.Remove(item);



                    ListViewItem nitem = new ListViewItem();
                    nitem.Text = ip.IpAddrs;
                    nitem.SubItems.Add(ip.Port);
                    this.All_Send_Addr_listView.Items.Add(nitem);

                    this.sendList.Remove(ip);
                }
                this.All_Send_Addr_listView.EndUpdate();
                this.Need_Send_Addr_listView.EndUpdate();


            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            if (this.Need_Send_Addr_listView.Items.Count == 0)
            {
                MessageBox.Show("发送地址为空!");
                return;
            }
            this.tabControl1.SelectedIndex = 1;
            this.loadSendList();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.removeFromAllList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.removeAllSelectedFromAllList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.addToAllList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.addAllToAllList();
        }

        private void All_Send_Addr_listView_DoubleClick(object sender, EventArgs e)
        {
            this.removeFromAllList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.tabControl1.ItemSize = new Size(0, 1);
            this.cmd_label.Text = this.message;
            this.loadList();
        }

        private void Need_Send_Addr_listView_DoubleClick(object sender, EventArgs e)
        {
            this.addToAllList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.send_result_listView.Items.Count == 0)
            {
                MessageBox.Show("发送地址为空!");
                return;
            }

            foreach(ListViewItem item in this.send_result_listView.Items)
            {
                this.send_result_listView.BeginUpdate();
                IpAddr ip = new IpAddr();
                ip.IpAddrs = item.Text;
                ip.Port = item.SubItems[1].Text;
                SocketUtil sktutil = new SocketUtil();
                Socket clientSocket = sktutil.getConnection(ip.IpAddrs, ip.Port);
                if (clientSocket != null)
                {
                   
                    bool success = sktutil.sendMessage(clientSocket, this.message);
                    if (success)
                    {
                        string response = sktutil.receiveMessage(clientSocket);
                        //MessageBox.Show(response);

                        item.SubItems.Add("回应："+response);
                    }else
                    {
                        item.SubItems.Add("失败");
                    }
                    
                    sktutil.disConnection(clientSocket);
                }
                else
                {
                    item.SubItems.Add("无法连接");
                }
                this.send_result_listView.EndUpdate();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }

        private void loadSendList()
        {
            this.send_result_listView.BeginUpdate();
            this.send_result_listView.Items.Clear();

            if (this.sendList != null)
            {
                foreach (IpAddr ip in this.sendList)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = ip.IpAddrs;
                    item.SubItems.Add(ip.Port);
                    this.send_result_listView.Items.Add(item);
                }
            }

            this.send_result_listView.EndUpdate();
        }
    }
}
