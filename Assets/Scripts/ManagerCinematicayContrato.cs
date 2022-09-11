using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerCinematicayContrato : MonoBehaviour
{
    [SerializeField] Eventos aparecerContrato,iniciarJuego;
    [SerializeField] float tiempoCinematica;
    void Start()
    {
        iniciarJuego.GEvent += CargarJuego;
        StartCoroutine("EsperarCinematica");
    }

    IEnumerator EsperarCinematica()
    {
        yield return new WaitForSeconds(tiempoCinematica);
        //Debug.Log("sale contrato");
        aparecerContrato.FireEvent();
    }
    void CargarJuego()
    {
        PlayerPrefs.SetInt("PrimeraVez", 1);
        SceneManager.LoadScene("Main");
    }
    private void OnDestroy()
    {
        iniciarJuego.GEvent -= CargarJuego;
    }
}
