using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosManager : MonoBehaviour
{
    [SerializeField] private AudioClip masticar, ladrar, eructo;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void Masticar()
    {
        audioSource.clip = masticar;
        audioSource.Play();
    }

    public void Ladrar()
    {
        audioSource.clip = ladrar;
        audioSource.Play();
    }

    public void Eructar()
    {
        audioSource.clip = eructo;
        audioSource.Play();
    }

    
}
