using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject PanelTienda;
    [SerializeField] GameObject Creditos;
    [SerializeField] GameObject PauseButton;
    [SerializeField] GameObject Comedero;
    [SerializeField] GameObject ComederoDogo;

    public void Paused()
    {
        pauseMenu.SetActive(true);
        PauseButton.SetActive(false);
        Time.timeScale = 0f;
        // Debug.Log("pausado");

    }
    public void Comederoo()
    {
        Comedero.SetActive(true);
        
        // Debug.Log("pausado");

    }
    public void ComederoDogoOpen()
    {
        ComederoDogo.SetActive(true);

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

    public void ExitComedero()
    {
        Comedero.SetActive(false);
        //Time.timeScale = 1f;
        //Debug.Log("Jugando");

    }
    public void ExitComederoDogo()
    {
        ComederoDogo.SetActive(false);
        //Time.timeScale = 1f;
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
    public void TiendaOpen()
    {
        PanelTienda.SetActive(true);
        Debug.Log("abriolatienda");

    }
    public void CloseTienda()
    {
        PanelTienda.SetActive(false);

    }




}
