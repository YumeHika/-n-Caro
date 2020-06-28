using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;

namespace Đồ_án_Caro
{
    public partial class Practice : Form
    {
        #region Properties
        Chess_Board_Manager_Practice ChessBoard;
        SocketManager socket;

        #endregion
        public Practice()
        {

            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            ChessBoard = new Chess_Board_Manager_Practice(pnlChessBoard, PlayerName_txb, Player_Ava_ptb);
            ChessBoard.Ended_Game += ChessBoard_EndedGame;
            ChessBoard.Player_Marked += ChessBoard_PlayerMarked;
            socket = new SocketManager();

            NewGame();
        }

        void EndGame()
        {
            pnlChessBoard.Enabled = false;
            MessageBox.Show("Kết thúc !!!");
        }
        void NewGame()
        {
            ChessBoard.DrawChessBoard();
        }
        void Quit()
        {
            Application.Exit();
        }

        void Undo()
        {
            ChessBoard.Undo();
        }
        void ChessBoard_PlayerMarked(object sender, ButtonClickEventPractice e)
        {
            pnlChessBoard.Enabled = false;

            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));

            UndoBtn.Enabled = false;

            Listen();
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            pnlChessBoard.Enabled = true;
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Practice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }
            }
        }
        private void Practice_Shown(object sender, EventArgs e)
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
                catch (Exception e)
                {
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }
        void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
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
                        pnlChessBoard.Enabled = true;
                        ChessBoard.OtherPlayerMark(data.Point);
                        UndoBtn.Enabled = true;
                    }));
                    break;
                case (int)SocketCommand.UNDO:
                    Undo();
                    break;
                case (int)SocketCommand.END_GAME:
                    MessageBox.Show("Đã 5 con trên 1 hàng");
                    break;
                case (int)SocketCommand.QUIT:
                    MessageBox.Show("Người chơi đã thoát");
                    break;
                default:
                    break;
            }
            Listen();
            //

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mode mode = new Mode();
            mode.Show();
            Quit();
        }
    }
}