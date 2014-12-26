using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;
namespace SerialCommunicate
{
    public partial class Form1 : Form
    {
        public Int64 TXcount=0,RXcount=0;
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)//打开端口按钮，单击触发
        {
            try//使用try以防出现异常
            {
                serialPort1.PortName = port.Text;//设置串口的名字为Combo控件里选择的条目的名字
                serialPort1.BaudRate = Convert.ToInt32(baud.Text,10);//设置串口的波特率为Combo控件里选择条目的波特率
                serialPort1.Open();//尝试打开串口

                portStatu.Text = "Open";//设置串口的状态打开，在文本控件中显示
                OpenPort.Enabled = false;//关闭使能打开串口按钮
                ClosePort.Enabled = true;//使能关闭串口按钮
            }
            catch//抓住异常显示如下内容 
            {
                MessageBox.Show("端口错误,请检查串口", "错误");
            }
        }

        private void Form1_Load(object sender, EventArgs e)//装载FORM时的函数
        {
            for (int i = 1; i < 10; i++)//有十个串口可供选择
            {
                port.Items.Add("COM" + i.ToString());//将每一个串口添加到Combo控件里以供选择
            }
            port.Text = "COM1";//设置控件默认显示的串口为COM1
            baud.Text = "4800";//设置控件默认显示的波特率为4800
            dataBit.Text = "8";//设置控件默认显示的数据位为8位
            verificationBit.Text = "None";//设置控件默认显示的奇偶校验位为None
            stopBit.Text = "1";//设置控件默认显示的停止位为1
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);//添加串口的接收事件函数
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)//串口的接受事件处理函数
        {
            if (!RXnum.Checked)//判断是否是接收字符模式，是的话往下执行
            {
                string str = serialPort1.ReadExisting();//读取串口控件缓冲区中的字符串
                str = str.Substring(0, str.Length - 1);//去除掉默认添加上字符上末尾的'/n'换行符
                textBox1.AppendText(str+' ');//在文本控件中显示接收到的字符串

                RXcount += str.Length;//使接收字符串计数器更新值
                RxByteCount.Text = Convert.ToString(RXcount,10);//将更新后的值显示到文本空间中
                
            }
            else 
            {   //如果是接收数值模式的话
                byte data;
                data = (byte)serialPort1.ReadByte();//对输入缓冲区中的数据一个字节一个字节处理
                string str = Convert.ToString(data, 16).ToUpper();//将数据转换为16进制
                textBox1.AppendText((str.Length == 1 ? "0" + str : str) + "H ");//在显示数据末尾添加'H'表示是16进制数

                RXcount += 1;//接收计数器自增1
                RxByteCount.Text = Convert.ToString(RXcount, 10);//将更新后的值显示到文本空间中
            }


        }



        private void button2_Click(object sender, EventArgs e)//关闭串口控件按钮，单击触发
        {
            try
            {
                serialPort1.Close();//关闭串口

                portStatu.Text = "Closed";//设置串口状态显示控件为关闭
                OpenPort.Enabled = true;//使能打开串口控件
                ClosePort.Enabled = false;//关闭使能串口关闭控件
            }
            catch (Exception err)//抓住异常
            {
                MessageBox.Show("关闭串口错误", "错误");//显示错误
            }
        }

        private void button3_Click(object sender, EventArgs e)//发送按钮处理函数
        {
            byte[] Data = new byte[1];
            if (serialPort1.IsOpen)//判断串口时候打开
            {
                if (textBox2.Text != "")//打开的情况下，如果发送文本框中有数据的话
                {
                    if (!TXnum.Checked)//如果是字符发送模式的话
                    {
                        try
                        {
                            string str;
                            str = textBox2.Text;
                            serialPort1.WriteLine(textBox2.Text);//写入串口


                            TXcount += str.Length;//更新发送计数器
                            TxByteCount.Text = Convert.ToString(TXcount, 10);//显示发送计数器数据

                        }
                        catch (Exception err)//抓住异常
                        {
                            MessageBox.Show("串口数据写入错误", "错误");//显示错误信息
                            serialPort1.Close();//有异常的话关闭串口
                            OpenPort.Enabled = true;//使能打开串口按钮
                            ClosePort.Enabled = false;//关闭使能关闭按钮
                        }
                    }
                    else
                    {
                        if (textBox2.Text.Length % 2 != 0)//如果字符串长度为为奇数的话单独处理第一位
                        {
                            Data[0] = Convert.ToByte(textBox2.Text.Substring(0, 1), 16);//截取第一位
                            serialPort1.Write(Data, 0, 1);//发送第一位
                        }
                        for (int i=0;i<(textBox2.Text.Length/2);i++)//发字符串长度一半的次数
                        {
                            Data[0] = Convert.ToByte(textBox2.Text.Substring(i * 2+textBox2.Text.Length%2, 2), 16);//发送字节，先转换为16进制再发
                            serialPort1.Write(Data, 0, 1);//发送
                        }

                        TXcount += (textBox2.Text.Length+1)/2;//更新计数器
                        TxByteCount.Text = Convert.ToString(TXcount, 10);//更新显示值


                   }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void verificationBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (verificationBit.SelectedIndex)
            {
                case 0: serialPort1.Parity = Parity.None; break;//设置校验位None
                case 1: serialPort1.Parity = Parity.Odd; break;//设置校验位奇校验
                case 2: serialPort1.Parity = Parity.Even; break;//设置校验位偶校验
                default: serialPort1.Parity = Parity.None; break;//默认无
            }
        }

        private void dataBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.DataBits = Convert.ToInt16(dataBit.Text, 10);//选择数据位
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RXcount = 0;//接收计数器清零
            textBox1.Clear();//清除接收文本框
        }

        private void TXclr_Click(object sender, EventArgs e)
        {
            TXcount = 0;//发送计数器清零
            textBox2.Clear();//清除发送文本框
        }

        private void clearCount_Click(object sender, EventArgs e)
        {
            TXcount = 0;//清除计数
            RXcount = 0;
            RxByteCount.Text = Convert.ToString(RXcount, 10);//显示更新值
            TxByteCount.Text = Convert.ToString(TXcount, 10);
        }

        private void stopBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (stopBit.SelectedIndex)
            {
                case 0: serialPort1.StopBits = System.IO.Ports.StopBits.One; break;//设置停止位1
                case 1: serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;break;//停止位1.5
                case 2: serialPort1.StopBits = System.IO.Ports.StopBits.Two; break;//停止位2
            }
        }

        private void auto_CheckedChanged(object sender, EventArgs e)
        {
            if (auto.Checked)//检查是否为自动发送是的话往下执行
            {
                textBox3.Enabled = false;//关闭使能定时器文本框
                timer1.Interval = Convert.ToInt32(textBox3.Text);//设置定时时间
                timer1.Enabled = true;//设能定时器
                timer1.Start();//定时器开始
            }
            else
            {
                textBox3.Enabled = true;//使能定时器文本框
                timer1.Stop();//关闭定时器
                timer1.Enabled = false;//关闭使能定时器

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();//关闭所有
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("DesignedBy:\nsonas_Guo\nMail:\nguolinsen123@163.com","Author");//显示相关信息
        }


    }
}
