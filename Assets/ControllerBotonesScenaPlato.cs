using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerBotonesScenaPlato : MonoBehaviour
{
    [SerializeField] GameObject panelAgrega;

    public void OpenPlato()
    {
        SceneManager.LoadScene("comedero");
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("Menu Principal");
    }

    public void OpenpanelAgregar()
    {
        panelAgrega.SetActive(true);

    }

    public void ClosepanelAgregar()
    {
        panelAgrega.SetActive(false);

    }
}
