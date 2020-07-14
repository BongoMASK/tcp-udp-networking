using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace GameServer
{
    class GameLogic {
        public static void Update() {
            ThreadManager.UpdateMain();
        }
    }
}