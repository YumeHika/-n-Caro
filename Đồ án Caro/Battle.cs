using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_Caro
{
    public partial class Battle : Form
    {
        #region Properties
        Chess_Board_Manager_Battle ChessBoard;
        SocketManager socket;
        #endregion

        public Battle()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;

            ChessBoard = new Chess_Board_Manager_Battle(pnlChessBoard, PlayerName_txb, Player_Ava_ptb);
            ChessBoard.Ended_Game += ChessBoard_Ended_Game;
            ChessBoard.Player_Marked += ChessBoard_Player_Marked;

            prsCountdown.Step = Cons.Countdown_Step;
            prsCountdown.Maximum = Cons.Countdown_Time;
            prsCountdown.Value = 0;

            tmCountdown.Interval = Cons.Countdown_Interval;

            socket = new SocketManager();
            NewGame();

        }

        void EndGame()
        {
            tmCountdown.Stop();
            pnlChessBoard.Enabled = false;
            MessageBox.Show("Kết thúc !!!");
        }

        void NewGame()
        {
            prsCountdown.Value = 0;
            tmCountdown.Stop();
            ChessBoard.DrawChessBoard();
        }

        void Quit()
        {
            Application.Exit();
        }

        private void ChessBoard_Ended_Game(object sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, " ", new Point()));
        }

        private void ChessBoard_Player_Marked(object sender, ButtonClickEventBattle e)
        {
            tmCountdown.Start();
            pnlChessBoard.Enabled = false;
            prsCountdown.Value = 0;

            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, " ", e.ClickedPoint));

            Listen();
        }

        private void tmCountdown_Tick(object sender, EventArgs e)
        {
            prsCountdown.PerformStep();

            if (prsCountdown.Value >= prsCountdown.Maximum)
            {
                EndGame();
                socket.Send(new SocketData((int)SocketCommand.TIME_OUT, " ", new Point()));
            }
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, " ", new Point()));
            pnlChessBoard.Enabled = true;
        }


        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Battle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát ra ???", "Thông báo !!!", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, " ", new Point()));
                }
                catch { }
            }
        }

        private void BtnLAN_Click(object sender, EventArgs e)
        {
            socket.IP = IPTxb.Text;

            if (!socket.ConnectServer())
            {
                socket.isServer = true;
                pnlChessBoard.Enabled = true;
                socket.CreateServer();
            }
            else
            {
                socket.isServer = false;
                pnlChessBoard.Enabled = false;
                Listen();
            }
        }

        private void Battle_Shown(object sender, EventArgs e)
        {
            IPTxb.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(IPTxb.Text))
            {
                IPTxb.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }

        void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();
                    ProcessData(data);
                }
                catch { }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Mess);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnlChessBoard.Enabled = false;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        prsCountdown.Value = 0;
                        pnlChessBoard.Enabled = true;
                        tmCountdown.Start();
                        ChessBoard.OtherPlayerMark(data.Point);
                    }));
                    break;
                case (int)SocketCommand.END_GAME:
                    MessageBox.Show("Đã đủ 5 quân trên 1 hàng !!!");
                    break;
                case (int)SocketCommand.TIME_OUT:
                    MessageBox.Show("Hết giờ !!");
                    break;
                case (int)SocketCommand.QUIT:
                    tmCountdown.Stop();
                    MessageBox.Show("Người chơi đã thoát !! ");
                    break;
                default:
                    break;
            }

            Listen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mode mode = new Mode();
            mode.Show();
            Quit();
        }
    }
}
