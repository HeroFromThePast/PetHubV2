using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private AudioClip musica1, musica2, musicaAlegre;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        Musica1();
    }

    public void Musica1()
    {
        audioSource.clip = musica1;
        audioSource.Play();
    }

    public void Musica2()
    {
        audioSource.clip = musica2;
        audioSource.Play();
    }

    public void MusicaAlegre()
    {
        audioSource.clip = musicaAlegre;
        audioSource.Play();
    }
}
