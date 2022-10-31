using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarGuardado : MonoBehaviour
{

    [SerializeField] Estadisticas stats;
    [SerializeField] ActualizarStats actualizar;
    void Awake()
    {
        CargarPerro();
    }

    private void OnApplicationQuit()
    {
        GuardarPerro();
    }

    void GuardarPerro()
    {
        //GuardarDatos.GuardarPerro(stats);
        PlayerPrefs.SetFloat("Salud", stats.salud);
        PlayerPrefs.SetFloat("Alimentacion", stats.alimentacion);
        PlayerPrefs.SetFloat("Animo", stats.animo);
    }

    void CargarPerro()
    {
        stats.salud = PlayerPrefs.GetFloat("Salud");
        stats.alimentacion = PlayerPrefs.GetFloat("Alimentacion");
        stats.animo = PlayerPrefs.GetFloat("Animo");
        actualizar.Actualizar();
        /*
            DatosPerro dPerro = GuardarDatos.CargarDatos();

            stats.salud = dPerro.salud;
            stats.alimentacion = dPerro.alimentacion;
            stats.animo = dPerro.animo;
        */
    }
}
