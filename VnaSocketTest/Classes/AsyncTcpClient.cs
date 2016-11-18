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

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CopperMountainTech
{
    internal class AsyncTcpClient
    {
        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        public bool connected { get; set; }
        public bool waitingForResponse { get; set; }
        public string ipAddressString { get; set; }
        public int portNumber { get; set; }

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        public class SocketPacket
        {
            public Socket thisSocket;
            public byte[] dataBuffer = new byte[4096];
        }

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        public delegate void CallbackEventHandler(string text);

        public event CallbackEventHandler ProcessReceivedDataCallback;

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        private IAsyncResult asyncResult;
        private AsyncCallback asyncCallback;
        private Socket clientSocket;

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        public AsyncTcpClient()
        {
            connected = false;
            waitingForResponse = false;
            ipAddressString = "";
            portNumber = 0;
        }

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        public bool Connect(string ip, int port)
        {
            connected = false;
            waitingForResponse = false;

            try
            {
                // create the socket
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // get the server IP address
                IPAddress ipAddress = IPAddress.Parse(ip);

                // create an end point
                IPEndPoint endPoint = new IPEndPoint(ipAddress, port);

                // connect to the server
                clientSocket.Connect(endPoint);

                // update connected property
                connected = clientSocket.Connected;

                if (connected)
                {
                    // update ip address and port number properties
                    ipAddressString = ip;
                    portNumber = port;

                    // wait for data asynchronously
                    waitForData();
                }
                else
                {
                    // init ip address and port number properties
                    ipAddressString = "";
                    portNumber = 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return connected;
        }

        public void Disconnect()
        {
            // close the socket
            if (clientSocket != null)
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
                clientSocket = null;
            }

            connected = false;
            waitingForResponse = false;
        }

        public void SendData(string data)
        {
            // send bytes
            try
            {
                if (clientSocket != null)
                {
                    byte[] byteData = Encoding.UTF8.GetBytes(data + "\r\n");
                    clientSocket.Send(byteData);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        private void waitForData()
        {
            try
            {
                if (asyncCallback == null)
                {
                    asyncCallback = new AsyncCallback(onDataReceived);
                }

                SocketPacket socketPacket = new SocketPacket();
                socketPacket.thisSocket = clientSocket;

                // start listening for data asynchronously
                asyncResult = clientSocket.BeginReceive(socketPacket.dataBuffer,
                                                        0,
                                                        socketPacket.dataBuffer.Length,
                                                        SocketFlags.None,
                                                        asyncCallback,
                                                        socketPacket);
            }
            catch (Exception)
            {
            }
        }

        private void onDataReceived(IAsyncResult result)
        {
            try
            {
                SocketPacket socketPacket = (SocketPacket)result.AsyncState;

                // returns the number of characters written to the stream
                int numberOfCharsInResult = socketPacket.thisSocket.EndReceive(result);
                char[] chars = new char[numberOfCharsInResult + 1];

                // extract the characters as a buffer
                System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
                int charLen = d.GetChars(socketPacket.dataBuffer, 0, numberOfCharsInResult, chars, 0);
                String resultText = new String(chars);

                if (ProcessReceivedDataCallback != null)
                {
                    ProcessReceivedDataCallback(resultText);
                }

                waitingForResponse = false;

                waitForData();
            }
            catch (ObjectDisposedException)
            {
                System.Diagnostics.Debugger.Log(0, "1", "\nonDataReceived: Socket has been closed\n");
            }
            catch (SocketException e)
            {
                System.Diagnostics.Debugger.Log(0, "1", e.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    }
}