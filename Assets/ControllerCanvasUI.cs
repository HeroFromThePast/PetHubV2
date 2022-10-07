using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerCanvasUI : MonoBehaviour
{
    public GameObject Menu,Settings,Credits,Salir,monedas, ButtonMenu, Info,Tips,Etiquetas,Store;
    private float waitTime = 2.0f;
    private float timer = 0.0f;
    public void SettingsOn()
    {
        Menu.SetActive(true);
        
        Time.timeScale = 0f;
        // Debug.Log("pausado");

    }
    public void Ajustes()
    {
        Menu.SetActive(false);
        Settings.SetActive(true);
    }
    public void CloseAjustes()
    {
        Time.timeScale = 1f;
        Settings.SetActive(false);
    }
    public void FAQ()
    {


    }
    public void Creditos()
    {
        ButtonMenu.SetActive(false);
        Menu.SetActive(false);
        Credits.SetActive(true);
    }
    public void CloseCreditos()
    {
        Time.timeScale = 1f;
        Credits.SetActive(false);
        ButtonMenu.SetActive(true);
    }

    public void Fakemoney()
    {
        monedas.SetActive(true);
        if (timer > waitTime)
        {
            monedas.SetActive(false);
            timer = timer - waitTime;
        }
    }
    public void OpenPanelSalirGame()
    {
        Time.timeScale = 0f; 
        Salir.SetActive(true);
        ButtonMenu.SetActive(false);
    }
    public void ClosePanelSalirGame()
    {
        Time.timeScale = 1f;
        Salir.SetActive(false);
        ButtonMenu.SetActive(true);
    }

    public void OpenTips()
    {
        Time.timeScale = 0f;
        Salir.SetActive(true);
        ButtonMenu.SetActive(false);
    }
    public void CloseTips()
    {
        Time.timeScale = 1f;
        Salir.SetActive(false);
        ButtonMenu.SetActive(true);
    }

    public void OpenInfo()
    {
        Time.timeScale = 0f;
        Info.SetActive(true);
        ButtonMenu.SetActive(false);
    }
    public void CloseInfo()
    {
        Time.timeScale = 1f;
        Info.SetActive(false);
        ButtonMenu.SetActive(true);
    }
    public void OpenEtiquetas()
    {
        Time.timeScale = 0f;
        Info.SetActive(false);
        Etiquetas.SetActive(true);
        ButtonMenu.SetActive(false);
    }
    public void CloseEtiquetas()
    {
        Time.timeScale = 1f;  
        Etiquetas.SetActive(false);
        ButtonMenu.SetActive(true);
    }

    public void OpenTienda()
    { 
        Time.timeScale = 0f;
        Store.SetActive(true);
        //ButtonMenu.SetActive(false);
    }
    public void CloseTienda()
    {
        Time.timeScale = 1f;
        Store.SetActive(false);
        //al ButtonMenu.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenAgenda()
    {
        SceneManager.LoadScene("Agenda");
    }

    public void OpenCoca()
    {
        SceneManager.LoadScene("Plato-Main");
    }

    public void CargarSala()
    {
        SceneManager.LoadScene("Sala");
    }

    public void CargarPatio()
    {
        SceneManager.LoadScene("Patio");
    }

    public void CargarMain()
    {
        SceneManager.LoadScene("Main");
    }
}