using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerBotonesScenaPlato : MonoBehaviour
{
    public void OpenPlato()
    {
        SceneManager.LoadScene("comedero");
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("Menu Principal");
    }
}
