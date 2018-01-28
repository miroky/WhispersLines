using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageUIController : MonoBehaviour {

    public Text txt1;
    public Text txt2;
    public Text txt3;

    private string[] _mensajes;

    // Use this for initialization
    void Start () {
        txt3.text = "";
        txt2.text = "";
        txt1.text = "";
    }

    public bool PrintMessage(string msg)
    {
        txt3.text = txt2.text;
        txt2.text = txt1.text;
        txt1.text = msg;
        return true;
    }
}
