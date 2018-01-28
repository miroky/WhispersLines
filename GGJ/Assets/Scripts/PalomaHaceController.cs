using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalomaHaceController : MonoBehaviour {

    public GameObject palomaAterriza;
    public GameObject palomaAparece;

    private Animator pAterriza;
    private Animator pAparece;

    private AudioSource audio;

    void Start()
    {
        pAparece = palomaAparece.GetComponent<Animator>();
        pAterriza = palomaAterriza.GetComponent<Animator>();

        audio = palomaAparece.GetComponent<AudioSource>();

        audio.Play();
    }

}
