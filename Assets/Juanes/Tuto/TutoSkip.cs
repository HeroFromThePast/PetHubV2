using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.Video;

public class TutoSkip : MonoBehaviour
{
    [SerializeField] GameObject PauseTuto;
    [SerializeField] AudioSource MyAudioSource;
    [SerializeField] VideoPlayer MiVideoPlayer;

    public void Paused()
    {
       
        PauseTuto.SetActive(true);
     
        Time.timeScale = 0f;
        // Debug.Log("pausado");
        MyAudioSource.Pause();
        MiVideoPlayer.Pause();

    }
   
    public void Resume()
    {
        PauseTuto.SetActive(false);
       
        Time.timeScale = 1f;
        //Debug.Log("Jugando");
        MyAudioSource.Play();
        MiVideoPlayer.Play();
    }

    public void LoadMain(int Main)
    {
        Time.timeScale = 1f;
        //Debug.Log("Cargando_Menu");
        SceneManager.LoadScene(Main);
    }

   
}
