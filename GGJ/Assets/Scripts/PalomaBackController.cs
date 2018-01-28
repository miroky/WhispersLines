using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalomaBackController : MonoBehaviour {

    public GameObject palomaDespega;
    public GameObject palomaDesaparece;

    private Animator pDespega;
    private Animator pDesaparece;

    private AudioSource audio;

    void Start()
    {
        pDesaparece = palomaDesaparece.GetComponent<Animator>();
        pDespega = palomaDespega.GetComponent<Animator>();

        audio = palomaDesaparece.GetComponent<AudioSource>();

        audio.Play();
    }
}
