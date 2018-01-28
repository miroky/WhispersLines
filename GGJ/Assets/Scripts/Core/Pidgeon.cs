using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pidgeon : MonoBehaviour {

    public PistaController PC;

    private string _pista;
    private bool _activated;

	// Use this for initialization
	void Start () {
        _pista = "There's going to be a conversation with SJ";
        _activated = true;
	}
	
    public bool Action()
    {
        // Mostrar pista por pantalla (durante 3 segundos)
        Debug.Log("La pista ha sido descubierta");
        PC.MostrarPista();

        // Desactivar Paloma
        _activated = false;
        return true;
    }
}
