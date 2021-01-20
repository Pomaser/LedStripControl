using System;
using System.Windows.Forms;
using System.IO.Ports;
using MechanikaDesign.WinForms.UI.ColorPicker;

namespace LedStripeControl
{
    public partial class Main : Form
    {

        // color values
        private int valueRed;
        private int valueGreen;
        private int valueBlue;
        private int effectNo;

        // active port name
        private String portName;
        String messageToSend = "";

        // init
        public Main()
        {
            InitializeComponent();
        }

        // create menu
        private void setRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // minimize window
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            bool MousePointerNotOnTaskbar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if (this.WindowState == FormWindowState.Minimized && MousePointerNotOnTaskbar) {
                notifyIcon1.Icon = Properties.Resources.Icon1;
                notifyIcon1.BalloonTipText = "Application has been minimized.";
                notifyIcon1.ShowBalloonTip(1000);
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        // maximize window
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            if (this.WindowState == FormWindowState.Normal)
            {
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }

        // save settings at close
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sendMessage(0, 0, 0, 0);
            serialPort1.Close();
            Properties.Settings.Default.RedLevel = valueRed;
            Properties.Settings.Default.GreenLevel = valueGreen;
            Properties.Settings.Default.BlueLevel = valueBlue;
            Properties.Settings.Default.PortIdx = comboBoxPortNo.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        // initialize when form loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            int lastPort = -1;
            serialPort1.Close();
            comboBoxEffect.SelectedIndex = 0;

            // load settings
            valueRed = Properties.Settings.Default.RedLevel;
            valueGreen = Properties.Settings.Default.GreenLevel;
            valueBlue = Properties.Settings.Default.BlueLevel;
            refreshSliders();

            // search all ports
            foreach (string ports in SerialPort.GetPortNames())
            {
                portName = ports.ToString();
                comboBoxPortNo.Items.Add(portName);
                lastPort++;
            }
            try
            {
                // get number of last port
                if (Properties.Settings.Default.PortIdx > lastPort)
                {
                    // last detected port
                    comboBoxPortNo.SelectedIndex = lastPort;
                } else
                {
                    // saved value
                    comboBoxPortNo.SelectedIndex = Properties.Settings.Default.PortIdx;
                }

                // set port parameters
                serialPort1.RtsEnable = false;
                serialPort1.DtrEnable = false;
                serialPort1.PortName = (portName);
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.Encoding = System.Text.Encoding.ASCII;
                serialPort1.Open();
            }
            catch
            {
                // error message
                label1.Text = "Port not avaiable!";
            }
        }

        // hexagon control
        private void colorHexagon_ColorChanged(object sender, ColorChangedEventArgs args)
        {
            valueRed = colorHexagon.SelectedColor.R;
            valueGreen = colorHexagon.SelectedColor.G;
            valueBlue = colorHexagon.SelectedColor.B;
            refreshSliders();
            sendMessage(valueRed, valueGreen, valueBlue, 0);
        }

        // send message button pressed
        private void sendButton_click(object sender, EventArgs e)
        {
            sendMessage(valueRed, valueGreen, valueBlue, 0 );
        }

        // send message to port
        private void sendMessage(int valueRed, int valueGreen, int valueBlue, int effectNo)
        {
            const String separator = ",";
            messageToSend = this.valueRed.ToString() + separator + this.valueGreen.ToString() + separator + this.valueBlue.ToString() + separator + this.effectNo.ToString() + "\r\n";
            try
            {
                serialPort1.Write(messageToSend);
                label1.Text = "Port number:";
            }
            catch
            {
                // error message
                label1.Text = "Port error!";
            }
        }

        private Timer _scrollingTimer = null;

        // scroll bar for RED color
        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            valueRed = trackBarRed.Value;
            textValueRed.Text = valueRed.ToString();
            
            if (_scrollingTimer == null)
            {
                // Will tick every 500ms (change as required)
                _scrollingTimer = new Timer()
                {
                    Enabled = false,
                    Interval = 200,
                    Tag = (sender as TrackBar).Value
                };
                _scrollingTimer.Tick += (s, ea) =>
                {
                    // check to see if the value has changed since we last ticked
                    if (trackBarRed.Value == (int)_scrollingTimer.Tag)
                    {
                        // scrolling has stopped so we are good to go ahead and do stuff
                        _scrollingTimer.Stop();
                        sendMessage(valueRed, valueGreen, valueBlue, 0);
                        _scrollingTimer.Dispose();
                        _scrollingTimer = null;
                    }
                    else
                    {
                        // record the last value seen
                        _scrollingTimer.Tag = trackBarRed.Value;
                    }
                };
                _scrollingTimer.Start();
            }
        }

        // scroll bar for BLUE color
        private void trackBarBlue_SCroll(object sender, EventArgs e)
        {
            valueGreen = trackBarGreen.Value;
            textValueGreen.Text = valueGreen.ToString();
            if (_scrollingTimer == null)
            {
                // Will tick every 500ms (change as required)
                _scrollingTimer = new Timer()
                {
                    Enabled = false,
                    Interval = 200,
                    Tag = (sender as TrackBar).Value
                };
                _scrollingTimer.Tick += (s, ea) =>
                {
                    // check to see if the value has changed since we last ticked
                    if (trackBarGreen.Value == (int)_scrollingTimer.Tag)
                    {
                        // scrolling has stopped so we are good to go ahead and do stuff
                        _scrollingTimer.Stop();
                        sendMessage(valueRed, valueGreen, valueBlue, 0);
                        _scrollingTimer.Dispose();
                        _scrollingTimer = null;
                    }
                    else
                    {
                        // record the last value seen
                        _scrollingTimer.Tag = trackBarGreen.Value;
                    }
                };
                _scrollingTimer.Start();
            }
        }

        // scroll bar for GREEN color
        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            valueBlue = trackBarBlue.Value;
            textValueBlue.Text = valueBlue.ToString();
            if (_scrollingTimer == null)
            {
                // Will tick every 500ms (change as required)
                _scrollingTimer = new Timer()
                {
                    Enabled = false,
                    Interval = 200,
                    Tag = (sender as TrackBar).Value
                };
                _scrollingTimer.Tick += (s, ea) =>
                {
                    // check to see if the value has changed since we last ticked
                    if (trackBarBlue.Value == (int)_scrollingTimer.Tag)
                    {
                        // scrolling has stopped so we are good to go ahead and do stuff
                        _scrollingTimer.Stop();
                        sendMessage(valueRed, valueGreen, valueBlue, 0);
                        _scrollingTimer.Dispose();
                        _scrollingTimer = null;
                    }
                    else
                    {
                        // record the last value seen
                        _scrollingTimer.Tag = trackBarBlue.Value;
                    }
                };
                _scrollingTimer.Start();
            }
        }

        // select COM port
        private void comboBoxPortSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            portName = comboBoxPortNo.SelectedItem.ToString();
            if (serialPort1.IsOpen) { serialPort1.Close(); }
            serialPort1.PortName = portName;
        }

        private void comboBoxPortSelection_Click(object sender, EventArgs e)
        {
            int lastPort = -1;

            comboBoxPortNo.Items.Clear();

            // search all ports
            foreach (string ports in SerialPort.GetPortNames())
            {
                portName = ports.ToString();
                comboBoxPortNo.Items.Add(portName);
                lastPort++;
            }
            try
            {
                // set port parameters
                serialPort1.PortName = (portName);
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.Encoding = System.Text.Encoding.Default;
            }
            catch
            {
                // error message
                label1.Text = "Port not avaiable!";
            }
        }

        private void colorHexagon1_Load(object sender, EventArgs e)
        {

        }

        // refresh values of sliders
        private void refreshSliders()
        {
            trackBarRed.Value = valueRed;
            trackBarGreen.Value = valueGreen;
            trackBarBlue.Value = valueBlue;

            textValueRed.Text = valueRed.ToString();
            textValueBlue.Text = valueBlue.ToString();
            textValueGreen.Text = valueGreen.ToString();

        }

        // effect changed
        private void comboBoxEffect_SelectedIndexChanged(object sender, EventArgs e)
        {
            effectNo = comboBoxEffect.SelectedIndex;
            sendMessage(valueRed, valueGreen, valueBlue, effectNo);
        }
    }
}