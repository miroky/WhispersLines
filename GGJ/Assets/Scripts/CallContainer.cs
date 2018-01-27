using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallContainer : MonoBehaviour
{

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
    void Start()
    {
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
        _stringAux.Add("The sentence is 'The eagles have reached the nest'.");
        _claveAux.Add(0);

        _listaLore.Add(new Call(R2, null, new Conversation(_stringAux, _claveAux, 1), 10, false));
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
        _stringAux.Add("Heil Doktor.");
        _claveAux.Add(0);
        _stringAux.Add("Heil mein Gebieter.");
        _claveAux.Add(0);
        _stringAux.Add("Do you have the results from the experiment? We need those eagles as soon as possible.");
        _claveAux.Add(1);
        _stringAux.Add("Yes. I'll send them in a couple of hours. Is the nest ready?");
        _claveAux.Add(2);
        _stringAux.Add("Yes, Doktor. We will win this time. Those disgusting rats will never see the sun again.");
        _claveAux.Add(0);
        _stringAux.Add("That's right my captain.");
        _claveAux.Add(0);
        _stringAux.Add("Well. Auf Wiedersehen.");
        _claveAux.Add(0);
        _stringAux.Add("Auf Wiedersehen.");
        _claveAux.Add(0);

        /*
		_stringAux.Add("Adios, que te peten");

        _claveAux.Add(1);
        _claveAux.Add(0);

        _listaConClave.Add(new Call(R2, D4, new Conversation(_stringAux, _claveAux, 0), 10, false));
		*/

        //_stringAux.Add("");
        //_claveAux.Add("");

        _listaConClave.Add(new Call(R1, D4, new Conversation(_stringAux, _claveAux, 8), 28, false));

    }
}