using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    class ServerSend {
        private static void SendTCPData(int _toCLient, Packet _packet) {
            _packet.WriteLength();
            Server.clients[_toCLient].tcp.SendData(_packet);
        }

        private static void SendTCPDataToAll(Packet _packet) {
            _packet.WriteLength();
            for(int i = 0; i <= Server.MaxPLayers ; i++) {
                Server.clients[i].tcp.SendData(_packet);
            }
        }

        private static void SendTCPDataToAll(int _exceptClient, Packet _packet) {
            _packet.WriteLength();
            for(int i = 0; i <= Server.MaxPLayers; i++) {
                if(i != _exceptClient) {
                    Server.clients[i].tcp.SendData(_packet);
                }
            }
        }
        
        public static void Welcome(int _toCLient, string _msg) {
            using (Packet _packet = new Packet((int)ServerPackets.welcome)) {
                _packet.Write(_msg);
                _packet.Write(_toCLient);

                SendTCPData(_toCLient, _packet); 
            }
        }

    }
}