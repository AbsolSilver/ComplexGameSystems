using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using UnityEngine;

public class Server : MonoBehaviour
{
    public int port;
    private List<ServerClient> clients;
    private List<ServerClient> disconnectList;
    private TcpListener server;
    private bool serverStarted;

    private void Update()
    {
        
    }

    void StartListening()
    {

    }

    void AcceptTcpClient(System.IAsyncResult result)
    {

    }

    bool isConnected()
    {

    }

    void Broadcast(string data, List<ServerClient> incomingClients)
    {

    }

    void Broadcast(string data, ServerClient incomingClient)
    {

    }

    void OnIncomingData (ServerClient client, string data)
    {

    }

    public void Init()
    {
        
    }


}
