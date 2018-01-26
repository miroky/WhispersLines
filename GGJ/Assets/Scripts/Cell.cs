using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {

    public GameManager GM;
    
    bool CallFromPlayer()
    {
        Debug.Log("Me has dado, soy " + this.name);

        return false;
    }
}
