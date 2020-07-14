using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    class ServerHandle {
        public static void welcomeReceived(int _fromClient, Packet _packet) {
            int _clientIdCheck = _clientIdCheck = _packet.ReadInt();
            string _username = _packet.ToString();

            Console.WriteLine(
             $"{Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint} connected successfully and is now player");
            if(_fromClient != _clientIdCheck) {
                Console.WriteLine
                 ($"Player \"{_username}\" (ID: {_fromClient}) has assumed the wrong ClientID ({_clientIdCheck})!");
            }
            //TODO: send player into game.
        }
    }
}