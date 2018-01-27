using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Call {

    private Cell _cellR;
    private Cell _cellD;
    private Conversation _conv;
    private float _duration;
    private bool _important;

    public Call(Cell R, Cell D, Conversation M, float dur, bool imp)
    {
        _cellR = R;
        _cellD = D;
        _conv = M;
        _duration = dur;
        _important = imp;
    }

    public Call(Cell D, Conversation M, float dur, bool imp)
    {
        _cellR = null;
        _cellD = D;
        _conv = M;
        _duration = dur;
        _important = imp;
    }

    public Cell GetReciver()
    {
        return _cellR;
    }

    public Cell GetDestination()
    {
        return _cellD;
    }

    public Conversation GetConversation()
    {
        return _conv;
    }

    public float GetDuration()
    {
        return _duration;
    }

    public bool GetImportance()
    {
        return _important;
    }
}
