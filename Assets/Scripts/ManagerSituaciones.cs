using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSituaciones : MonoBehaviour
{
    [SerializeField] SituacionesYCambios[] situaciones;
    [SerializeField] Estadisticas mascota;
    void Start()
    {
        situaciones[Random.Range(0, situaciones.Length)].AlterarStats(mascota);
    }
}
