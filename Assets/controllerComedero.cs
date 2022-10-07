using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controllerComedero : MonoBehaviour
{
    [SerializeField] GameObject reserva,rellenar,historial,diario,conf;
    public void BackPlato()
    {
        SceneManager.LoadScene("Plato-Main");
    }

    public void OpenReserva()
    {
        reserva.SetActive(true);

    }

    public void CloseReserva()
    {
        reserva.SetActive(false);

    }

    public void OpenRellenar()
    {
        rellenar.SetActive(true);

    }

    public void CloseRellenar()
    {
        rellenar.SetActive(false);

    }

    public void OpenHistorial()
    {
        historial.SetActive(true);

    }

    public void CloseHistorial()
    {
        historial.SetActive(false);

    }
    public void OpenDiarios()
    {
        diario.SetActive(true);

    }

    public void CloseDiario()
    {
        diario.SetActive(false);

    }

    public void OpenConf()
    {
        conf.SetActive(true);

    }

    public void CloseConf()
    {
        conf.SetActive(false);

    }

}
