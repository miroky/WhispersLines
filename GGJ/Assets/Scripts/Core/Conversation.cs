using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversation {

    private List<string> _contenido;
    private List<int> _clave;
    private int _num;

    #region Constructores
    public Conversation(List<string> menList, List<int> clave, int num)
    {
        _contenido = menList;
        _clave = clave;
        _num = num;        
    }
    #endregion

    #region Metodos
    public string GetTexto(int cont)
    {
        return _contenido[cont];
    }

    public int GetClave(int cont)
    {
        return _clave[cont];
    }

    public int GetNumTexto()
    {
        return _num;
    }
    #endregion

}
