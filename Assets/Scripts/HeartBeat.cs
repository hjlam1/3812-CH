using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class HeartBeat : MonoBehaviour {

    public SerialController aPorts;
    private string[] portList;
    public string thePort;
    public GameObject theHeart;

    private void Awake()
    {
        Screen.SetResolution(400, 300, false);
    }
    
    void Start () {
        aPorts.enabled = false;
        Debug.Log("Port Listing");
        portList = SerialPort.GetPortNames();
        for (int i = portList.Length-1; i >= 0; i--) {
            if (portList[i].Length > 4)
            {
                thePort = "\\\\.\\" + portList[i];
            }
            else
            {
                thePort = portList[i];
            }
            SerialController clone = (SerialController)Instantiate(aPorts, transform.position, transform.rotation);
            clone.enabled = false;
            clone.portName = thePort;
            clone.messageListener = this.gameObject;
            Debug.Log(thePort);
            clone.enabled = true;
            //aPorts.portName = thePort;
            //aPorts.enabled = true;
        }
        
     }
	
	void Update () {
        theHeart = GameObject.FindGameObjectWithTag("SerialPort");
    }
}
