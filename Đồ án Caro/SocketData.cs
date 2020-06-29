using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án_Caro
{
    [Serializable]
    public class SocketData
    {
        private int command;
        public int Command { get => command; set => command = value; }

        private Point point;
        public Point Point { get => point; set => point = value; }

        private string mess;
        public string Mess { get => mess; set => mess = value; }

        public SocketData(int command, string mess, Point point)
        {
            this.Command = command;
            this.Point = point;
            this.Mess = mess;
        }
    }

    public enum SocketCommand
    {
        SEND_POINT,
        NOTIFY,
        NEW_GAME,
        UNDO,
        END_GAME,
        TIME_OUT,
        CHAT,
        QUIT
    }
}
