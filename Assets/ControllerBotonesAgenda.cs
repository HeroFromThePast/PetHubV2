using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerBotonesAgenda : MonoBehaviour
{

    [SerializeField] public GameObject panelNewTare, panelMidia, panelCalendario,recuadroMiDia,recuadroCalendario,AgregarNoti,
        enero,febrero,marzo,abril, mayo, junio, julio, agosto, septiembre, octubre, nov, dicksiembre;


    public void OpenMiDia()
    {
        panelCalendario.SetActive(false);
        recuadroCalendario.SetActive(false);
        recuadroMiDia.SetActive(true);
        panelMidia.SetActive(true);
    }

    public void OpenCalendario()
    {
        panelCalendario.SetActive(true);
        recuadroCalendario.SetActive(true);
        recuadroMiDia.SetActive(false);
        panelMidia.SetActive(false);
    }


    public void OpenDiaA_Dia()
    {
        AgregarNoti.SetActive(true);
    }

    public void CloseDiaA_Dia()
    {    
        AgregarNoti.SetActive(false);
    }

    public void OpenEnero()
    {
        panelCalendario.SetActive(false);
        enero.SetActive(true);
    }

    public void CloseEnero()
    {
        panelCalendario.SetActive(true);
        enero.SetActive(false);
    }

    public void OpenFebrero()
    {
        panelCalendario.SetActive(false);
        febrero.SetActive(true);
    }

    public void CloseFebrero()
    {
        panelCalendario.SetActive(true);
        febrero.SetActive(false);
    }
    public void OpenMarzo()
    {
        panelCalendario.SetActive(false);
        marzo.SetActive(true);
    }

    public void CloseMArzo()
    {
        panelCalendario.SetActive(true);
        marzo.SetActive(false);
    }

    public void OpenAbril()
    {
        panelCalendario.SetActive(false);
        abril.SetActive(true);
    }

    public void CloseAbril()
    {
        panelCalendario.SetActive(true);
        abril.SetActive(false);
    }
    public void OpenMayo()
    {
        panelCalendario.SetActive(false);
        mayo.SetActive(true);
    }

    public void CloseMayo()
    {
        panelCalendario.SetActive(true);
        mayo.SetActive(false);
    }
    public void OpenJunio()
    {
        panelCalendario.SetActive(false);
        junio.SetActive(true);
    }

    public void CloseJunio()
    {
        panelCalendario.SetActive(true);
        junio.SetActive(false);
    }
    public void OpenJulio()
    {
        panelCalendario.SetActive(false);
        julio.SetActive(true);
    }

    public void CloseJulio()
    {
        panelCalendario.SetActive(true);
        julio.SetActive(false);
    }
    public void OpenAgo()
    {
        panelCalendario.SetActive(false);
        agosto.SetActive(true);
    }

    public void CloseAGo()
    {
        panelCalendario.SetActive(true);
        agosto.SetActive(false);
    }
    public void OpenSep()
    {
        panelCalendario.SetActive(false);
        septiembre.SetActive(true);
    }

    public void CloseSep()
    {
        panelCalendario.SetActive(true);
        septiembre.SetActive(false);
    }

    public void OpenOct()
    {
        panelCalendario.SetActive(false);
        octubre.SetActive(true);
    }

    public void CloseOct()
    {
        panelCalendario.SetActive(true);
        octubre.SetActive(false);
    }

    public void OpenNov()
    {
        panelCalendario.SetActive(false);
        nov.SetActive(true);
    }

    public void CloseNov()
    {
        panelCalendario.SetActive(true);
        nov.SetActive(false);
    }

    public void OpenDic()
    {
        panelCalendario.SetActive(false);
        dicksiembre.SetActive(true);
    }

    public void CloseDic()
    {
        panelCalendario.SetActive(true);
        dicksiembre.SetActive(false);
    }

    public void OpenNewTarea()
    {
        panelNewTare.SetActive(true);
      
    }

    public void CloseNewTarea()
    {
        panelNewTare.SetActive(false);
        
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("Menu Principal");
    }
}
