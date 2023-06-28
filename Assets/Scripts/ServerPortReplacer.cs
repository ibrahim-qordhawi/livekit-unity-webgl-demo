using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using Mirror.SimpleWeb;

public class ServerPortReplacer : MonoBehaviour
{
    NetworkManager networkManager;
    // Start is called before the first frame update
    void Start()
    {
        networkManager = GetComponent<NetworkManager>();
        string strPort = Constants.ServerPort;
        ushort port = ushort.Parse(strPort);
        networkManager.GetComponent<SimpleWebTransport>().port = port;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
