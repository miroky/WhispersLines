using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private Cell firstCell;
    [SerializeField]
    private Cell secondCell;

    public Cell GetFirstCell()
    {
        return firstCell;
    }

    public void SetFistCell(Cell cell)
    {
        firstCell = cell;
    }

    public Cell GetSecondCell()
    {
        return secondCell;
    }

    public void SetSecondCell(Cell cell)
    {
        secondCell = cell;
    }
}
