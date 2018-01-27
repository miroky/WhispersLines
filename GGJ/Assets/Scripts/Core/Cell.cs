using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {

    public GameManager GM;
    
    private bool _Use;
    private bool _Calling;

    #region Funciones Unity

    void Start()
    {
        _Use = false;
        _Calling = false;
    }

    void Update()
    {
        if (this.tag == "Cell_R")
        {
            if (_Calling)
            {
                // Encender Luz (Hijo)
            }
            else
            {
                // Apagar Luz (Hijo)
            }
        }
    }

    #endregion

    #region Getters y Setters

    public bool GetUse()
    {
        return _Use;
    }

    public void SetUse(bool use)
    {
        _Use = use;
    }

    #endregion

    public bool CallCable()
    {
        Debug.Log("Me has dado, soy " + this.name);

        // Si la celda es Receptora...
        if(this.tag == "Cell_R")
        {
            if (!this._Use && GM.SetFirstCellArray(this))
            {
                _Use = true;
                return true;
            }
        }
        // Si no, la celda es Destino...
        else
        {
            if (!this._Use && GM.SetSecondCellArray(this))
            {
                _Use = true;
                return true;
            }
        }

        return false;
    }

    public bool CallSpecialCable()
    {
        // Debug.Log("Me has dado, soy " + this.name);

        // Si la celda es Receptora...
        if (this.tag == "Cell_R")
        {
            if (!this._Use && GM.SetFirstSpecialCable(this))
            {
                _Use = true;
                return true;
            }
        }
        // Si no, la celda es Destino...
        else
        {
            if (!this._Use && GM.SetSecondSpecialCable(this))
            {
                _Use = true;
                return true;
            }
        }

        return false;
    }

    public void SetCalling(bool aux)
    {
        _Calling = aux;
    }
}
