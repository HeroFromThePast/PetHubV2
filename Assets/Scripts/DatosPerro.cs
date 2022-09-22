using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DatosPerro
{
    //[SerializeField] Estadisticas stats;
    public float salud;
    public float alimentacion;
    public float animo;

    public DatosPerro (Estadisticas stats) {
        salud = stats.salud;
        alimentacion = stats.alimentacion;
        animo = stats.animo;
    }
}
