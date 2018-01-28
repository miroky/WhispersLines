using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapelController : MonoBehaviour {

    public GameObject winPaper;
    public GameObject losePaper;

    public void MostrarWinPaper()
    {
        StartCoroutine(WaitWinPista());
    }

    public void MostrarLosePaper()
    {
        StartCoroutine(WaitLosePista());
    }

    IEnumerator WaitWinPista()
    {
        winPaper.SetActive(true);
        yield return new WaitForSeconds(4);
        winPaper.SetActive(false);
    }

    IEnumerator WaitLosePista()
    {
        losePaper.SetActive(true);
        yield return new WaitForSeconds(4);
        losePaper.SetActive(false);
    }
}
