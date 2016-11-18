// Copyright ©2016 Copper Mountain Technologies
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR
// ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using CopperMountainTech;
using System;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace VnaSocketTest
{
    public partial class FormMain : Form
    {
        private AsyncTcpClient asyncTcpClient = new AsyncTcpClient();

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        private delegate void appendToLogTextBoxCallback(string s);

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        public FormMain()
        {
            InitializeComponent();

            // --------------------------------------------------------------------------------------------------------

            // set form icon
            Icon = Properties.Resources.app_icon;

            // set program name
            Text = Program.programName;

            // disable resizing the plug-in window
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = true;

            // position in the center of the screen
            CenterToScreen();

            // --------------------------------------------------------------------------------------------------------

            // set version label text
            toolStripStatusLabelVersion.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version.ToString(3);

            // --------------------------------------------------------------------------------------------------------

            // update the controls
            updateControls(false);

            // populate IP and Port
            textBoxIP.Text = getLocalIPAddress();
            textBoxPort.Text = "5025";

            // set focus to connect button
            buttonConnect.Focus();

            // --------------------------------------------------------------------------------------------------------
        }

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        private void connectTcp()
        {
            // is there a tcp connection to the vna?
            if (asyncTcpClient.connected == false)
            {
                // no...

                try
                {
                    // create a new tcp client object
                    asyncTcpClient = new AsyncTcpClient();

                    // connect to server
                    asyncTcpClient.Connect(textBoxIP.Text, Convert.ToInt32(textBoxPort.Text));

                    // configure received data callback event handler
                    asyncTcpClient.ProcessReceivedDataCallback += new AsyncTcpClient.CallbackEventHandler(receiveTcpData);

                    // log the event
                    appendToLogTextBox("Connected thru TCP/IP Socket");
                }
                catch (Exception e)
                {
                    // show exception error message
                    MessageBox.Show("Please make sure the Socket Server is ON and the TCP/IP Port matches on the VNA software." +
                                    "\n\n" + e.Message,
                                    Program.programName,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // log the event
                    appendToLogTextBox("ERROR: Could Not Connect to the VNA thru TCP");
                }

                // update vna panel ui
                updateControls(asyncTcpClient.connected);
            }
        }

        private void disconnectTcp()
        {
            // is there a tcp connection to the vna?
            if (asyncTcpClient.connected == true)
            {
                // yes...

                // disconnect from server
                asyncTcpClient.Disconnect();

                // update vna panel ui
                updateControls(asyncTcpClient.connected);

                // log the event
                appendToLogTextBox("Disconnected from TCP/IP Socket");
            }
        }

        private void sendTcpData(string s)
        {
            // is there a tcp connection to the vna?
            if (asyncTcpClient.connected == true)
            {
                // yes...

                try
                {
                    // send the data
                    asyncTcpClient.SendData(s);

                    // log the sent data
                    appendToLogTextBox(">> " + s);
                }
                catch (Exception e)
                {
                    // show exception error message
                    MessageBox.Show("Please make sure the Socket Server is ON and the TCP/IP Port matches on the VNA software." +
                                    "\n\n" + e.Message,
                                    Program.programName,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Thread.Sleep(50); // TODO:
            }
        }

        private void receiveTcpData(string s)
        {
            // log the received data
            appendToLogTextBox("<< " + s);
        }

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        private void sendCommand()
        {
            // send the command to the vna
            sendTcpData(textBoxCommand.Text);

            // clear the command text
            textBoxCommand.Clear();

            // set focus to command text box
            textBoxCommand.Focus();
        }

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        private void updateControls(bool connected)
        {
            textBoxIP.Enabled = !connected;
            textBoxPort.Enabled = !connected;
            buttonConnect.Enabled = !connected;
            buttonDisconnect.Enabled = connected;
            buttonCmdIdn.Enabled = connected;
            buttonCmdOpc.Enabled = connected;
            buttonCmdCls.Enabled = connected;
            buttonCmdRst.Enabled = connected;
            buttonCmdSystErr.Enabled = connected;
            textBoxCommand.Enabled = connected;
            buttonSend.Enabled = connected;
            if (connected == false)
            {
                textBoxCommand.Clear();
            }
            toolStripStatusLabelText.Text = connected ? "Connected" : "Not Connected";
        }

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // is IP or port text field empty?
            if (textBoxIP.Text == "" || textBoxPort.Text == "")
            {
                // yes, show error message
                MessageBox.Show("Please enter the Server IP Address and Port Number.",
                    Program.programName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // clear the message text box
            textBoxLog.Clear();

            // open tcp socket connection to vna
            connectTcp();

            // set focus to command text box
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            // close tcp socket connection to vna
            disconnectTcp();

            // set focus to connect button
            buttonConnect.Focus();
        }

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        private void buttonCmdIdn_Click(object sender, EventArgs e)
        {
            textBoxCommand.Text = "*IDN?";
            sendCommand();
        }

        private void buttonCmdOpc_Click(object sender, EventArgs e)
        {
            textBoxCommand.Text = "*OPC?";
            sendCommand();
        }

        private void buttonCmdCls_Click(object sender, EventArgs e)
        {
            textBoxCommand.Text = "*CLS";
            sendCommand();
        }

        private void buttonCmdRst_Click(object sender, EventArgs e)
        {
            textBoxCommand.Text = "*RST";
            sendCommand();
        }

        private void buttonCmdSystErr_Click(object sender, EventArgs e)
        {
            textBoxCommand.Text = "SYST:ERR?";
            sendCommand();
        }

        // ------------------------------------------------------------------------------------------------------------

        private void buttonSend_Click(object sender, EventArgs e)
        {
            sendCommand();
        }

        private void textBoxCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check for Return key press
            if (e.KeyChar == 13)
            {
                sendCommand();
            }
        }

        // ------------------------------------------------------------------------------------------------------------

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // clear received messages
            textBoxLog.Clear();
        }

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        private void appendToLogTextBox(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                // NOTE: the following is needed to make a thread-safe call
                // InvokeRequired compares the thread ID of the
                // calling thread to the thread ID of the creating thread.
                // If these threads are different, it returns true.
                if (!this.IsDisposed)
                {
                    if (this.textBoxLog.InvokeRequired)
                    {
                        appendToLogTextBoxCallback d = new appendToLogTextBoxCallback(appendToLogTextBox);

                        try
                        {
                            this.BeginInvoke(d, new object[] { s });
                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        // append time stamp, text string, and new line
                        textBoxLog.AppendText(DateTime.Now.ToString("hh:mm:ss.fff tt") + ": " + s + Environment.NewLine);
                    }
                }
            }
        }

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        private string getLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        private void FormVnaSocketTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            // is there a tcp connection to the vna?
            if (asyncTcpClient.connected == true)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    // display confirmation dialog
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the application?",
                        Program.programName,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        // close tcp socket connection to vna
                        disconnectTcp();

                        e.Cancel = false;
                    }
                }
            }
        }

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    }
}