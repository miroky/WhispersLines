using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistaController : MonoBehaviour {

    public GameObject Pista;

    public void MostrarPista()
    {
        StartCoroutine(WaitPista());
    }

    IEnumerator WaitPista()
    {
        Pista.SetActive(true);
        yield return new WaitForSeconds(4);
        Pista.SetActive(false);
    }
}
