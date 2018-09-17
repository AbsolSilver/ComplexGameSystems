using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using UnityEngine;

public class Client : MonoBehaviour
{

    public new string clientName;
    public bool isHost;
    public List<GameClient> players;
    private bool socketReady;
    private TcpClient socket;
    private NetworkStream stream;
    private StreamWriter writer;
    private StreamReader reader;


    private void Start()
    {
        // DontDestroyOnLoad
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        // If socket is ready
        if(socketReady)
        {
            // Check if the stream's data is avaiable
            if(stream.DataAvailable)
            {
                // Get the data from reader
                string data = reader.ReadLine();
                if (data != null)
                {
                    OnIncomingData();
                }
            }
        }
    }

    private void OnApplicationQuit()
    {

    }

    private void OnDisable()
    {

    }

    void OnIncomingData()
    {

    }

    void UserConnected()
    {

    }

    void CloseSocket()
    {

    }

    public void ConnectedToServer(string host, int port)
    {

    }

    public Send(string data)
    {

    }
}
