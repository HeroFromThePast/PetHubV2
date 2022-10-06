using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarGuardado : MonoBehaviour
{

    [SerializeField] Estadisticas stats;
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
        GuardarDatos.GuardarPerro(stats);
    }

    void CargarPerro()
    {
        DatosPerro dPerro = GuardarDatos.CargarDatos();

        stats.salud = dPerro.salud;
        stats.alimentacion = dPerro.alimentacion;
        stats.animo = dPerro.animo;
    }
}
