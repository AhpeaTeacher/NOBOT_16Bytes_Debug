using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;

namespace 串口手柄助手V1._0
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll")]
        public static extern  UInt32 joyGetNumDevs();

        [StructLayout(LayoutKind.Sequential)]
        public struct JOYINFO
        {
            public UInt32 wXpos;                 /* x position */
            public UInt32 wYpos;                 /* y position */
            public UInt32 wZpos;                 /* z position */
            public UInt32 wButtons;              /* button states */
        }
        [DllImport("winmm.dll")]
        public static extern int joyGetPos(int uJoyID, ref JOYINFO pji);

        JOYINFO joyinfo;//joystick

        Int32 tolerance;//前后向容差

        UInt16 motion = 5;/* 1 2 3
                           * 4 5 6
                           * 7 8 9
                           */
        
        UInt16 speed_rank = 0;//0 1 2 3

        float linespeed1, linespeed2, linespeed3, anglespeed1, anglespeed2, anglespeed3;
        UInt16 linespeed_ratio = 100, anglespeed_ratio = 1000;

        public Form1()
        {
            InitializeComponent();
            if (joyGetNumDevs() == 0)
            {
                tbxJoySupportStatus.Text = "此设备不支持";
            }
            else
            {
                tbxJoySupportStatus.Text = "此设备支持";
                joyinfo.wXpos = 32767;
                joyinfo.wYpos = 32767;
                joyinfo.wZpos = 32767;
                joyinfo.wButtons = 0;              
            }
            tolerance = Convert.ToInt32(tbxTolerance.Text);
            timer1.Interval = 1000 / Convert.ToInt32(tbxTimer.Text);
            linespeed1 = float.Parse(tbxLineSpeed1.Text);
            anglespeed1 = float.Parse(tbxAngelSpeed1.Text);
            linespeed2 = float.Parse(tbxLineSpeed2.Text);
            anglespeed2 = float.Parse(tbxAngelSpeed2.Text);
            linespeed3 = float.Parse(tbxLineSpeed3.Text);
            anglespeed3 = float.Parse(tbxAngelSpeed3.Text);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                serialPort1.PortName = cbxPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbxBaud.Text);
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                try
                {
                    serialPort1.Open();
                    btnOpen.Text = "关闭串口";
                    timer1.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("打开串口失败");
                }
            }
            else
            {
                serialPort1.Close();
                btnOpen.Text = "打开串口";
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tbxJoySupportStatus.Text == "此设备支持")
            {
                joyGetPos(0, ref joyinfo);

                tbxXpos.Text = Convert.ToString(joyinfo.wXpos);
                tbxYpos.Text = Convert.ToString(joyinfo.wYpos);

                //方向判断
                if (joyinfo.wYpos < (32767 - 7000))
                {
                    if ((joyinfo.wXpos > (32767 - tolerance)) && (joyinfo.wXpos < (32767 + tolerance)))
                    {
                        rbtFor.Checked = true;
                        motion = 2;
                    }
                    else if (joyinfo.wXpos <= (32767 - tolerance))
                    {
                        rbtLeftFor.Checked = true;
                        motion = 1;
                    }
                    else if ((joyinfo.wXpos >= (32767 + tolerance)))
                    {
                        rbtRightFor.Checked = true;
                        motion = 3;
                    }
                }
                else if (joyinfo.wYpos > (32767 + 7000))
                {
                    if ((joyinfo.wXpos > (32767 - tolerance)) && (joyinfo.wXpos < (32767 + tolerance)))
                    {
                        rbtBack.Checked = true;
                        motion = 8;
                    }
                    else if (joyinfo.wXpos <= (32767 - tolerance))
                    {
                        rbtLeftBack.Checked = true;
                        motion = 7;
                    }
                    else if ((joyinfo.wXpos >= (32767 + tolerance)))
                    {
                        rbtRightBack.Checked = true;
                        motion = 9;
                    }

                }
                else
                {
                    rbtStop.Checked = true;
                    motion = 5;
                }
                //速度判断
                if (joyinfo.wButtons == 0x01)
                {
                    rbtA.Checked = true;
                    speed_rank = 1;
                }
                else if (joyinfo.wButtons == 0x02)
                {
                    rbtB.Checked = true;
                    speed_rank = 2;
                }
                else if (joyinfo.wButtons == 0x04)
                {
                    rbtX.Checked = true;
                    speed_rank = 3;
                }
                else
                {
                    rbtA.Checked = false;
                    rbtB.Checked = false;
                    rbtX.Checked = false;
                    speed_rank = 0;
                }
                //命令发送
                UInt16 linespeed_cmd = 0;
                UInt16 anglespeed_cmd = 0;
                if ((motion == 1) || (motion == 2) || (motion == 3))//确定前进线速度
                {
                    if (speed_rank == 0)
                    {
                        linespeed_cmd = 0;
                    }
                    else if (speed_rank == 1)
                    {
                        linespeed_cmd = (UInt16)(linespeed1 * linespeed_ratio);
                    }
                    else if (speed_rank == 2)
                    {
                        linespeed_cmd = (UInt16)(linespeed2 * linespeed_ratio);
                    }
                    else if (speed_rank == 3)
                    {
                        linespeed_cmd = (UInt16)(linespeed3 * linespeed_ratio);
                    }
                }
                else if ((motion == 7) || (motion == 8) || (motion == 9))//确定后退线速度
                {
                    if (speed_rank == 0)
                    {
                        linespeed_cmd = 0;
                    }
                    else if (speed_rank == 1)
                    {
                        linespeed_cmd = (UInt16)(~((UInt16)(linespeed1 * linespeed_ratio)) + 1);
                    }
                    else if (speed_rank == 2)
                    {
                        linespeed_cmd = (UInt16)(~((UInt16)(linespeed2 * linespeed_ratio)) + 1);
                    }
                    else if (speed_rank == 3)
                    {
                        linespeed_cmd = (UInt16)(~((UInt16)(linespeed3 * linespeed_ratio)) + 1);
                    }
                }
                if ((motion == 1) || (motion == 7))//确定左转角速度
                {
                    if (speed_rank == 0)
                    {
                        anglespeed_cmd = 0;
                    }
                    else if (speed_rank == 1)
                    {
                        anglespeed_cmd = (UInt16)(anglespeed1 * anglespeed_ratio);
                    }
                    else if (speed_rank == 2)
                    {
                        anglespeed_cmd = (UInt16)(anglespeed2 * anglespeed_ratio);
                    }
                    else if (speed_rank == 3)
                    {
                        anglespeed_cmd = (UInt16)(anglespeed3 * anglespeed_ratio);
                    }
                }
                else if ((motion == 3) || (motion == 9))//确定右转角速度
                {
                    if (speed_rank == 0)
                    {
                        anglespeed_cmd = 0;
                    }
                    else if (speed_rank == 1)
                    {
                        anglespeed_cmd = (UInt16)(~((UInt16)(anglespeed1 * anglespeed_ratio)) + 1);
                    }
                    else if (speed_rank == 2)
                    {
                        anglespeed_cmd = (UInt16)(~((UInt16)(anglespeed2 * anglespeed_ratio)) + 1);
                    }
                    else if (speed_rank == 3)
                    {
                        anglespeed_cmd = (UInt16)(~((UInt16)(anglespeed3 * anglespeed_ratio)) + 1);
                    }
                }

                byte[] SendBuff = new byte[16] { 0xAA, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x55 };
                SendBuff[4] = (byte)(linespeed_cmd / 256);
                SendBuff[5] = (byte)(linespeed_cmd % 256);
                SendBuff[8] = (byte)(anglespeed_cmd / 256);
                SendBuff[9] = (byte)(anglespeed_cmd % 256);
                serialPort1.Write(SendBuff, 0, 16);//发送命令

                //if (rbxTx.Lines.Length == 0x07)
                   // rbxTx.Clear();

                for (int i = 0; i < 16; i++)
                {
                    if (SendBuff[i] < 0x10)
                        rbxTx.AppendText("0");
                    rbxTx.AppendText(Convert.ToString(SendBuff[i], 16).ToUpper());
                    rbxTx.AppendText(" ");
                }
                rbxTx.AppendText("\n");
                rbxTx.ScrollToCaret();
            }
        }

        private void btnSetJoy_Click(object sender, EventArgs e)
        {
            tolerance = Convert.ToInt32(tbxTolerance.Text);

            timer1.Interval = 1000 / Convert.ToInt32(tbxTimer.Text);
        }

        private void btnSetSpeed_Click(object sender, EventArgs e)
        {
            if ((float.Parse(tbxLineSpeed1.Text) > 3.0) || (float.Parse(tbxLineSpeed2.Text) > 3.0) || (float.Parse(tbxLineSpeed3.Text) > 3.0))
            {
                MessageBox.Show("线速度须小于 3.0 m/s");
            }
            if ((float.Parse(tbxLineSpeed1.Text) < 0) || (float.Parse(tbxLineSpeed2.Text) < 0) || (float.Parse(tbxLineSpeed3.Text) < 0))
            {
                MessageBox.Show("线速度不能小于0");
            }
            if ((float.Parse(tbxAngelSpeed1.Text) > 0.5) || (float.Parse(tbxAngelSpeed2.Text) > 0.5) || (float.Parse(tbxAngelSpeed2.Text) > 0.5))
            {
                MessageBox.Show("角速度须小于 0.5 rad/s");
            }
            if ((float.Parse(tbxAngelSpeed1.Text) < 0) || (float.Parse(tbxAngelSpeed2.Text) < 0) || (float.Parse(tbxAngelSpeed3.Text) < 0))
            {
                MessageBox.Show("角速度不能小于0");
            }
            linespeed1 = float.Parse(tbxLineSpeed1.Text);
            anglespeed1 = float.Parse(tbxAngelSpeed1.Text);
            linespeed2 = float.Parse(tbxLineSpeed2.Text);
            anglespeed2 = float.Parse(tbxAngelSpeed2.Text);
            linespeed3 = float.Parse(tbxLineSpeed3.Text);
            anglespeed3 = float.Parse(tbxAngelSpeed3.Text);
        }
    }
}
