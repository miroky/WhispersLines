using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallManager : MonoBehaviour {

    public GameManager GM;
    public CallContainer CC;

    private Call[] _llamadas;

    #region Unity Functions
    void Start () {
        _llamadas = new Call[GM.maxLlamadas];
        GenerateCalls(1);
	}
    #endregion

    #region Custom Functions
    private void GenerateCalls(int numDia)
    {
        // Si el dia es el 1...
        if(numDia == 1)
        {
            // Coger X llamadas de Lore


            // Coger un numero de llamadas con clave...


            // Coger un numero de llamadas sin clave...



        }
    }
    #endregion
}
