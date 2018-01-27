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
            _llamadas[0] = CC._listaLore[0];
            _llamadas[1] = CC._listaSinClave[0];
            _llamadas[2] = CC._listaSinClave[1];
            _llamadas[3] = CC._listaConClave[0];
            _llamadas[4] = CC._listaSinClave[2];
            _llamadas[5] = CC._listaConClave[1];
            _llamadas[6] = CC._listaConClave[2];
            _llamadas[7] = CC._listaSinClave[3];
            _llamadas[8] = CC._listaSinClave[4];
            _llamadas[9] = CC._listaSinClave[5];
        }
    }

    public Call GetLlamada(int cont)
    {
        return _llamadas[cont];
    }
    #endregion
}
