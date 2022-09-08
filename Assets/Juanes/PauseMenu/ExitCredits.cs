using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCredits : MonoBehaviour
{
    [SerializeField] GameObject paauseMenu;
    [SerializeField] GameObject Creeditos;
    public void Resume()
    {
        paauseMenu.SetActive(false);
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
