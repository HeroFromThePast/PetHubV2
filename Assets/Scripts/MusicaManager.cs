using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaManager : MonoBehaviour
{
    [SerializeField] AudioClip musica1, musica2, musicaAlegre;
    private AudioSource adSource;
    void Start()
    {
        adSource = gameObject.GetComponent<AudioSource>();
        Musica1();
    }
    
    public void Musica1()
    {
        adSource.clip = musica1;
        adSource.Play();
    }

    public void Musica2()
    {
        adSource.clip = musica2;
        adSource.Play();
    }

    public void MusicaAlegre()
    {
        adSource.clip = musicaAlegre;
        adSource.Play();
    }
}
