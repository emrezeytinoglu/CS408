using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Game
{
    public partial class Form1 : Form
    {
        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<Socket> clientSockets = new List<Socket>();
        List<string> usernames = new List<string>();
        List<string> questions = new List<string>();
        List<string> answers = new List<string>();

        List<string> answers1 = new List<string>();
        List<string> answers2 = new List<string>();

        bool terminating = false;
        bool listening = false;

        int score1 = 0;
        int score2 = 0;
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            listening = false;
            terminating = true;
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int serverPort;
            string filename = @"C:\Users\saffe\desktop\questions.txt";
            string[] lines = File.ReadAllText(filename).Split('\n');
            for (int i = 0; i < 22; i+=2)
            {
                questions.Add(lines[i]);
                answers.Add(lines[i + 1]);
            }

            if (Int32.TryParse(textBox1.Text, out serverPort))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, serverPort);
                serverSocket.Bind(endPoint);
                serverSocket.Listen(3);

                listening = true;
                button1.Enabled = false;

                Thread acceptThread = new Thread(Accept);
                acceptThread.Start();
                logs.AppendText("Started listening on port: " + serverPort + "\n");
            }
            else
            {
                logs.AppendText("Please check port number \n");
            }
        }
        private void Accept()
        {
            if (listening)
            {
                try
                {
                    Socket newClient = serverSocket.Accept();
                    logs.AppendText("A client is connected.\n");
                    Thread receiveThread = new Thread(() => ReceiveUsername(newClient)); // updated
                    receiveThread.Start();
                }
                catch
                {
                    if (terminating)
                    {
                        listening = false;
                    }
                    else
                    {
                        logs.AppendText("The socket stopped working.\n");
                    }

                }
            }
        }
        private void ReceiveUsername(Socket thisClient) // updated
        {
            bool connected = true;
            Byte[] buffer = new Byte[64];
            if (connected && !terminating && clientSockets.Count() < 2)
            {
                try
                {
                    thisClient.Receive(buffer);

                    string incomingMessage = Encoding.Default.GetString(buffer);
                    incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));
                    if (usernames.Contains(incomingMessage) && !clientSockets.Contains(thisClient))
                    {
                        Byte[] buffers = Encoding.Default.GetBytes("This username is taken, please try to connect again with another username.");
                        thisClient.Send(buffers);
                        logs.AppendText("Taken username, disconnecting from the server.");
                        thisClient.Close();
                        connected = false;
                    }
                    else
                    {
                        usernames.Add(incomingMessage);
                        clientSockets.Add(thisClient);
                        if (usernames.Count() == 1)
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                Thread receiveThread = new Thread(() => game(thisClient)); // updated
                            }
                        }
                    }
                }
                catch
                {
                    if (!terminating)
                    {
                        logs.AppendText("A client has disconnected\n");
                    }
                    thisClient.Close();
                    clientSockets.Remove(thisClient);
                    connected = false;
                }
            }
        }
        private void game(Socket thisClient) // updated
        {
            bool connected = true;
            long questionCount = Convert.ToInt64(textBox2.Text);
            int askedCount = 0;
            int i = clientSockets.IndexOf(thisClient);

            while (connected && !terminating && askedCount < questionCount)
            {
                try
                {
                    Byte[] qbuffer = Encoding.Default.GetBytes(questions[askedCount]);
                    thisClient.Send(qbuffer);
                    Byte[] abuffer = new Byte[64];
                    string incomingMessage = Encoding.Default.GetString(abuffer);
                    incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));
                    if (i == 0)
                    {
                        answers1.Add(incomingMessage);
                    }
                    else if (i == 1)
                    {
                        answers2.Add(incomingMessage);
                    }

                    askedCount++;
                }
                catch
                {
                    if (!terminating)
                    {
                        logs.AppendText("A client has disconnected\n");
                    }
                    thisClient.Close();
                    clientSockets.Remove(thisClient);
                    connected = false;
                }
            }
        }
    }
}
