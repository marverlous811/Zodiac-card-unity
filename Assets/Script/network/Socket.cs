using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using WebSocket4Net;

class Socket
{
    public void connect()
    {
        Debug.Log("hello");
        WebSocket websocket = new WebSocket("ws://echo.websocket.org");
        websocket.Opened += new EventHandler(this.websocketOpened);
        websocket.Open();
    }

    private void websocketOpened(object sender, EventArgs e)
    {
        Debug.Log("connected");
    }
}
