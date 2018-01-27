using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int max_Cables;
    public int maxLlamadas;

    public int minIntervalWait;
    public int maxIntervalWait;

    public int porcentajeConClave;

    public CallManager CM;
    public MessageUIController MC;

    private int _enUso;
    private int _iteracion;
    private int _turnoPaloma;
    private bool _startGame;

    private Cell[,] _conexiones;
    private Cable[] _cables;

    private Cell _firstSpecialCable;
    private Cell _secondSpecialCable;

    #region Funciones Unity

    // Funcion que se ejecuta en la creacion del objeto
    void Start()
    {
        _conexiones = new Cell[max_Cables, 2];
        _cables = new Cable[max_Cables + 1];

        _enUso = 0;

        for (int i = 0; i < max_Cables; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                _conexiones[i,j] = null;
            }
        }

        _firstSpecialCable = null;
        _secondSpecialCable = null;
        _turnoPaloma = Random.Range(2, 6);
        _startGame = false;

        StartCoroutine(StartGame(2, 5));
    }
    #endregion

    #region Funciones 'Gestion Conexiones'

    public bool SetFirstCellArray(Cell celda)
    {
        // Si existe en los cables especiales, está en uso y su par está registrado...
        if(celda == _firstSpecialCable && _firstSpecialCable.GetUse() && _secondSpecialCable != null)
        {
            return false;
        }

        for (int i = 0; i < max_Cables; i++)
        {
            // Si la celda que estamos viendo es null...
            Cell auxCell = _conexiones[i, 0];
            if(auxCell == null)
            {
                return SetFirstCell(i, celda);
            }
            else
            {
                // Si la celda no está en uso...
                if (!auxCell.GetUse())
                {
                    return SetFirstCell(i, celda);
                }

                // Si la celda está en uso, pero no tiene par...
                if(auxCell.GetUse() && _conexiones[i, 1] == null)
                {
                    return SetFirstCell(i, celda);
                }
            }
        }

        return false;
    }

    private bool SetFirstCell(int count, Cell celda)
    {
        _conexiones[count, 0] = celda;
        _conexiones[count, 1] = null;
        return true;
    }

    public bool SetSecondCellArray(Cell celda)
    {
        // Si existe en los cables especiales, está en uso y su par está registrado...
        if (celda == _secondSpecialCable && _secondSpecialCable.GetUse())
        {
            return false;
        }

        for (int i = 0; i < max_Cables; i++)
        {
            // Si la celda par NO es null...
            if(_conexiones[i,0] != null)
            {
                Cell auxCellS = _conexiones[i, 1];
                // Si la celda que estamos viendo es null...
                if (auxCellS == null)
                {
                    return SetSecondCell(i, celda);
                }
            }
        }

        return false;
    }

    private bool SetSecondCell(int count, Cell celda)
    {
        _conexiones[count, 1] = celda;
        return true;
    }

    public bool SetFirstSpecialCable(Cell celda)
    {
        // Si existe en el array de cables normales y está en uso...
        for(int i = 0; i<max_Cables; i++)
        {
            Cell auxS = _conexiones[i,0];
            if (auxS == celda && auxS.GetUse() && _conexiones[i, 1] != null)
            {
                return false;
            }
        }

        // Si el cable está a null...
        if (_firstSpecialCable == null)
        {
            return SetFirstSpecial(celda);
        }
        else
        {
            // Si el cable no se está usando...
            if (!_firstSpecialCable.GetUse())
            {
                return SetFirstSpecial(celda);
            }

            //Si el cable se está usando, pero su par no está definido...
            if(_firstSpecialCable.GetUse() && _secondSpecialCable == null)
            {
                return SetFirstSpecial(celda);
            }

        }

        return false;

    }

    public bool SetFirstSpecial(Cell celda)
    {
        _firstSpecialCable = celda;
        return true;
    }

    public bool SetSecondSpecialCable(Cell celda)
    {
        // Si existe en el array de cables normales y está en uso...
        for (int i = 0; i < max_Cables; i++)
        {
            Cell auxS = _conexiones[i, 1];
            if (auxS == celda && auxS.GetUse())
            {
                return false;
            }
        }

        // Si la celda par NO es null...
        if (_firstSpecialCable != null)
        {
            // Si la celda que estamos viendo es null...
            if (_secondSpecialCable == null)
            {
                return SetSecondSpecial(celda);
            }
        }

        // Si NO existe en el array de cables normales y NO está en uso...

        return false;
    }

    public bool SetSecondSpecial(Cell celda)
    {
        _secondSpecialCable = celda;
        return true;
    }

    public void DebugConexiones()
    {
        Debug.Log("[" + _conexiones[0,0] + "," + _conexiones[0, 1] + "] " + "[" + _conexiones[1, 0] + "," + _conexiones[1, 1] + "] " + "[" + _conexiones[2, 0] + "," + _conexiones[2, 1] + "]");
        Debug.Log("1E: " + _firstSpecialCable + ", 2E: " + _secondSpecialCable);
    }

    #endregion

    #region 'Funcionalidad Llamadas'

    IEnumerator StartGame(int min, int max)
    {
        yield return new WaitForSeconds(Random.Range(min, max));
        ++_iteracion;
        StartCoroutine(GameFlow());
    }

    IEnumerator GameFlow()
    {
        Debug.Log(_iteracion);

        if (_iteracion < maxLlamadas) { 
            yield return new WaitForSeconds(Random.Range(maxIntervalWait, maxIntervalWait));

            // Habilitamos la llamada que toca por medio de '_interval'
            Call habilitada = CM.GetLlamada(_iteracion);
            _enUso++;
            _iteracion++;

            Debug.Log(habilitada.GetReciver());

            // Iluminamos alarma en la celda
            habilitada.GetReciver().SetCalling(true);

            // Esperamos durante X hasta que el jugador establezca la comunicación 1a
            StartCoroutine(WaitCogerLlamada(10, habilitada));
        }
    }

    IEnumerator WaitCogerLlamada(int num, Call habilitada)
    {
        for(int i = 0; i < num; i++)
        {
            yield return new WaitForSeconds(1);
            if (habilitada.GetReciver().GetUse())
                break;
        }

        if (!habilitada.GetReciver().GetUse())
        {
            StartCoroutine(WaitEndCommunication(habilitada));
        }
        else
        {
            MC.PrintMessage(habilitada.GetConversation().GetTexto(0));
            StartCoroutine(WaitDesviarLlamada(10, habilitada));
        }
    }

    IEnumerator WaitDesviarLlamada(int num, Call habilitada)
    {
        Debug.Log(habilitada.GetDestination());
        for (int i = 0; i < num; i++)
        {
            yield return new WaitForSeconds(1);
            if (habilitada.GetDestination().GetUse())
                break;
        }

        if (!habilitada.GetDestination().GetUse())
        {
            StartCoroutine(WaitEndCommunication(habilitada));
        }
        else
        {
            if (_secondSpecialCable == habilitada.GetDestination())
            {
                StartCoroutine(WaitDialogo(habilitada));
            }
            else
            {
                StartCoroutine(WaitDefault(10f, habilitada));
            }
        }
    }

    IEnumerator WaitDialogo(Call aux)
    {
        float fTime = aux.GetDuration();
        Debug.Log(fTime);
        for(int i = 1; i<aux.GetConversation().GetNumTexto(); i++)
        {
            MC.PrintMessage(aux.GetConversation().GetTexto(i));
            yield return new WaitForSeconds(fTime/aux.GetConversation().GetNumTexto());
        }

        StartCoroutine(WaitEndCommunication(aux));
    }

    IEnumerator WaitDefault(float num, Call aux)
    {
        yield return new WaitForSeconds(num);

        StartCoroutine(WaitEndCommunication(aux));
    }

    IEnumerator WaitEndCommunication(Call habilitada)
    {
        habilitada.GetReciver().SetUse(false);
        habilitada.GetDestination().SetUse(false);

        //Apagamos luz alarma en la celda
        habilitada.GetReciver().SetCalling(false);

        StartCoroutine(GameFlow());
        yield return new WaitForSeconds(1);        
    }

    #endregion

}
