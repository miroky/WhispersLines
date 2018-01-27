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
        GenerateCalls();
	}
    #endregion

    #region Custom Functions
    private void GenerateCalls()
    {
        // Si el dia es el 1...
        int random = Random.Range(0, 10);
        Debug.Log(random);
        if(random >= 5)
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
        else
        {
            _llamadas[0] = CC._listaLore[1];
            _llamadas[1] = CC._listaSinClave[7];
            _llamadas[2] = CC._listaSinClave[8];
            _llamadas[3] = CC._listaConClave[3];
            _llamadas[4] = CC._listaSinClave[9];
            _llamadas[5] = CC._listaConClave[4];
            _llamadas[6] = CC._listaConClave[5];
            _llamadas[7] = CC._listaSinClave[10];
            _llamadas[8] = CC._listaSinClave[11];
            _llamadas[9] = CC._listaSinClave[12];
        }

        DebugLlamadas();
    }

    public Call GetLlamada(int cont)
    {
        return _llamadas[cont];
    }
    #endregion

    public void DebugLlamadas()
    {
        for(int i = 0; i < GM.maxLlamadas; i++)
        {
            Debug.Log(i + ": " + _llamadas[i].GetReciver() + " - " + _llamadas[i].GetDestination());
        }        
    }
}
