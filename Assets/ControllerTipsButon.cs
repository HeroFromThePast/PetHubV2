using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerTipsButon : MonoBehaviour
{

    [SerializeField] float duracionTip, aparicionTip;
    [SerializeField] Vector2 posicionNueva, posicionInicial;
    [SerializeField] GameObject PanelTipComida,Dogo1,Dogo2;

    void Start()
    {
        Dogo1.transform.localScale = Vector2.zero;
        Dogo1.transform.localPosition = posicionInicial;
    }

    public void OpenFAQTip()
    {
        Time.timeScale = 0f;
        PanelTipComida.SetActive(true);
        //ButtonMenu.SetActive(false);
    }
    public void CloseFAQTip()
    {
        Time.timeScale = 0f;
        PanelTipComida.SetActive(false);
        //ButtonMenu.SetActive(false);
    }


    public void OpenDogoTIP()
    {
        Time.timeScale = 0f;
        Dogo1.SetActive(true);
        //ButtonMenu.SetActive(false);
    }

    public void CloseDogoTIP()
    {
        Time.timeScale = 1f;
        Dogo1.SetActive(false);
        //al ButtonMenu.SetActive(true);
    }

    public void OpenDogoTIP2()
    {
        Time.timeScale = 0f;
        Dogo2.SetActive(true);
        //ButtonMenu.SetActive(false);
    }

    public void CloseDogoTIP2()
    {
        Time.timeScale = 1f;
        Dogo2.SetActive(false);
        //al ButtonMenu.SetActive(true);
    }

    public void CargarMainDesdeFAQ()
    {
        SceneManager.LoadScene("Main");
    }
}
