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

    public bool SetFirstCellArray(Cell celda)
    {
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
                if(auxCell.GetUse() && !_conexiones[i, 1].GetUse())
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

    #endregion
}
