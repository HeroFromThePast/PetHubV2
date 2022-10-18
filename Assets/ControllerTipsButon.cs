using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerTipsButon : MonoBehaviour
{

    [SerializeField] float duracionTip, aparicionTip;
    [SerializeField] Vector2 posicionNueva, posicionInicial;
    [SerializeField] GameObject PanelTipComida,PanelSalud,PanelEnergia,PanelComportamiento,Dogo1,Dogo2, Dogo3, DogoS1, DogoS2, DogoS3, DogoE1, DogoE2, DogoE3,
        DogoC1, DogoC2, DogoC3;

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

    public void OpenFAQTipSalud()
    {
        Time.timeScale = 0f;
        PanelSalud.SetActive(true);
        //ButtonMenu.SetActive(false);
    }
    public void CloseFAQTipSalud()
    {
        Time.timeScale = 0f;
        PanelSalud.SetActive(false);
        //ButtonMenu.SetActive(false);
    }

    public void OpenFAQTipEnergia()
    {
        Time.timeScale = 0f;
        PanelEnergia.SetActive(true);
        //ButtonMenu.SetActive(false);
    }
    public void CloseFAQTipEnergia()
    {
        Time.timeScale = 0f;
        PanelEnergia.SetActive(false);
        //ButtonMenu.SetActive(false);
    }

    public void OpenFAQTipComportamiento()
    {
        Time.timeScale = 0f;
        PanelComportamiento.SetActive(true);
        //ButtonMenu.SetActive(false);
    }
    public void CloseFAQTipComportamiento()
    {
        Time.timeScale = 0f;
        PanelComportamiento.SetActive(false);
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

    public void OpenDogoTIP3()
    {
        Time.timeScale = 0f;
        Dogo3.SetActive(true);
        //ButtonMenu.SetActive(false);
    }

    public void CloseDogoTIP3()
    {
        Time.timeScale = 1f;
        Dogo3.SetActive(false);
        //al ButtonMenu.SetActive(true);
    }

    public void OpenDogoTIPSalud1()
    {
        Time.timeScale = 0f;
        DogoS1.SetActive(true);
        //ButtonMenu.SetActive(false);
    }

    public void CloseDogoTIPSalud1()
    {
        Time.timeScale = 1f;
        DogoS1.SetActive(false);
        //al ButtonMenu.SetActive(true);
    }

    public void OpenDogoTIPSalud2()
    {
        Time.timeScale = 0f;
        DogoS2.SetActive(true);
        //ButtonMenu.SetActive(false);
    }

    public void CloseDogoTIPSalud2()
    {
        Time.timeScale = 1f;
        DogoS2.SetActive(false);
        //al ButtonMenu.SetActive(true);
    }

    public void OpenDogoTIPSalud3()
    {
        Time.timeScale = 0f;
        DogoS3.SetActive(true);
        //ButtonMenu.SetActive(false);
    }

    public void CloseDogoTIPSalud3()
    {
        Time.timeScale = 1f;
        DogoS3.SetActive(false);
        //al ButtonMenu.SetActive(true);
    }

    public void OpenDogoTIPEnergia1()
    {
        Time.timeScale = 0f;
        DogoE1.SetActive(true);
        //ButtonMenu.SetActive(false);
    }

    public void CloseDogoTIPEnergia1()
    {
        Time.timeScale = 1f;
        DogoE1.SetActive(false);
        //al ButtonMenu.SetActive(true);
    }

    public void OpenDogoTIPEnergia2()
    {
        Time.timeScale = 0f;
        DogoE2.SetActive(true);
        //ButtonMenu.SetActive(false);
    }

    public void CloseDogoTIPEnergia2()
    {
        Time.timeScale = 1f;
        DogoE2.SetActive(false);
        //al ButtonMenu.SetActive(true);
    }

    public void OpenDogoTIPEnergia3()
    {
        Time.timeScale = 0f;
        DogoE3.SetActive(true);
        //ButtonMenu.SetActive(false);
    }

    public void CloseDogoTIPEnergia3()
    {
        Time.timeScale = 1f;
        DogoE3.SetActive(false);
        //al ButtonMenu.SetActive(true);
    }

    public void OpenDogoTIPComp1()
    {
        Time.timeScale = 0f;
        DogoC1.SetActive(true);
        //ButtonMenu.SetActive(false);
    }

    public void CloseDogoTIPComp1()
    {
        Time.timeScale = 1f;
        DogoC1.SetActive(false);
        //al ButtonMenu.SetActive(true);
    }

    public void OpenDogoTIPComp2()
    {
        Time.timeScale = 0f;
        DogoC2.SetActive(true);
        //ButtonMenu.SetActive(false);
    }

    public void CloseDogoTIPComp2()
    {
        Time.timeScale = 1f;
        DogoC2.SetActive(false);
        //al ButtonMenu.SetActive(true);
    }

    public void OpenDogoTIPComp3()
    {
        Time.timeScale = 0f;
        DogoC3.SetActive(true);
        //ButtonMenu.SetActive(false);
    }

    public void CloseDogoTIPComp3()
    {
        Time.timeScale = 1f;
        DogoC3.SetActive(false);
        //al ButtonMenu.SetActive(true);
    }
    public void CargarMainDesdeFAQ()
    {
        SceneManager.LoadScene("Main");
    }
}
