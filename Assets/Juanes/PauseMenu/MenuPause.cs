using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject Creditos;
    [SerializeField] GameObject PauseButton;

    public void Paused()
    {
        pauseMenu.SetActive(true);
        PauseButton.SetActive(false);
        Time.timeScale = 0f;
        // Debug.Log("pausado");

    }

    public void Credits()
    {
        Creditos.SetActive(true);
        Time.timeScale = 0f;
        // Debug.Log("pausado");

    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 1f;
        //Debug.Log("Jugando");

    }
    public void ExitCredits()
    {
        Creditos.SetActive(false);
        Time.timeScale = 1f;
        //Debug.Log("Jugando");

    }


    public void LoadMenu(int menu)
    {
        Time.timeScale = 1f;
        //Debug.Log("Cargando_Menu");
        SceneManager.LoadScene(menu);
    }
    public void QuitGame()
    {

        Application.Quit();
    }




}
