using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosManager : MonoBehaviour
{
    [SerializeField] AudioClip eructo, masticar, ladrido;
    private AudioSource adSource;

    private void Start()
    {
        adSource = gameObject.GetComponent<AudioSource>();
    }

    public void Eructo()
    {
        adSource.clip = eructo;
        adSource.Play();
    }

    public void Masticar()
    {
        adSource.clip = masticar;
        adSource.Play();
    }

    public void Ladrido()
    {
        adSource.clip = ladrido;
        adSource.Play();
    }
}
