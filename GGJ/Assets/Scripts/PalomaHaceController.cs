using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalomaHaceController : MonoBehaviour {

    public Animator palomaAterriza;
    public Animator palomaAparece;

    public AudioSource audio;

    void Start()
    {
        palomaAterriza = GetComponent<Animator>();   
    }

    public void AterrizarPaloma()
    {
        palomaAterriza
        palomaAparece.Play();

        audio.Play();
    }

    public void DespegaPaloma()
    {

    }

}
