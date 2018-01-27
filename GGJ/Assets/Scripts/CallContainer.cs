using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallContainer : MonoBehaviour {

    #region Variables    
    public Cell R1;
    public Cell R2;
    public Cell R3;
    public Cell R4;
    public Cell R5;
    public Cell R6;
    public Cell R7;
    public Cell R8;

    public Cell D1;
    public Cell D2;
    public Cell D3;
    public Cell D4;
    public Cell D5;
    public Cell D6;
    public Cell D7;
    public Cell D8;

    private List<Call> _listaLore;
    private List<Call> _listaSinClave;
    private List<Call> _listaConClave;

    private List<string> _stringAux;
    private List<int> _claveAux;
    #endregion

    // Use this for initialization
    void Start () {
        _listaLore = new List<Call>();
        _listaSinClave = new List<Call>();
        _listaConClave = new List<Call>();

        _stringAux = new List<string>();
        _claveAux = new List<int>();

        GenerarLore();
        GenerarSinClave();
        GenerarConClave();
	}

    private void GenerarLore()
    {
        _stringAux.Add("Hola, soy pepe");
        _stringAux.Add("Adios, que te peten");

        _claveAux.Add(1);
        _claveAux.Add(0);

        _listaLore.Add(new Call(R2, D4, new Conversation(_stringAux, _claveAux, 2), 10, false));
    }

    private void GenerarSinClave()
    {
        _stringAux.Add("Hola, soy pepe");
        _stringAux.Add("Adios, que te peten");

        _claveAux.Add(1);
        _claveAux.Add(0);

        _listaSinClave.Add(new Call(R2, D4, new Conversation(_stringAux, _claveAux, 0), 10, false));
    }

    private void GenerarConClave()
    {
        _stringAux.Add("Hola, soy pepe");
        _stringAux.Add("Adios, que te peten");

        _claveAux.Add(1);
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R2, D4, new Conversation(_stringAux, _claveAux, 0), 10, false));
    }
}
