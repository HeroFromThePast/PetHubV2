using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerTipsButon : MonoBehaviour
{
    [SerializeField] GameObject PanelTipComida;
    public void OpenFAQTip()
    {
        Time.timeScale = 0f;
        PanelTipComida.SetActive(true);
        //ButtonMenu.SetActive(false);
    }

    public void CloseFAQTip()
    {
        Time.timeScale = 1f;
        PanelTipComida.SetActive(false);
        //al ButtonMenu.SetActive(true);
    }

    public void CargarMainDesdeFAQ()
    {
        SceneManager.LoadScene("Main");
    }
}
