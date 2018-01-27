using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int max_Cables;

    private Cell[,] _conexiones;
    
    #region Funciones Unity

    // Funcion que se ejecuta en la creacion del objeto
    void Start()
    {
        _conexiones = new Cell[max_Cables, 2];
        Debug.Log(_conexiones.Length);

        for (int i = 0; i < max_Cables; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                _conexiones[i,j] = null;
            }
        }
    }

    // Funcion que se ejecuta cada update del juego
    void Update()
    {
        
    }
    #endregion

    #region Funciones 'Gestion Conexiones'

    public bool SetFirstCell(Cell celda)
    {
        return true;
    }

    public bool SetSecondCell(Cell celda)
    {
        return true;
    }

    #endregion
}
