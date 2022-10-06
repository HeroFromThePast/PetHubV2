using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InicioEstadisticas : MonoBehaviour
{
    DateTime tiempo;
    TimeSpan diferencia;
    int valorMinutos;
    [SerializeField] ActualizarStats actualizar;
    [SerializeField] Estadisticas stats;
    void Start()
    {
        if (PlayerPrefs.HasKey("TiempoUltimo"))
        {
            tiempo = Convert.ToDateTime(PlayerPrefs.GetString("TiempoUltimo"));

            diferencia = DateTime.Now - tiempo;
            Debug.Log(diferencia.Minutes);
            
            if(diferencia.Minutes > 5)
            {
                valorMinutos = diferencia.Minutes / 5;
                stats.disminucionA = 10 * valorMinutos;
                stats.disminucionAl = 10 * valorMinutos;
                stats.disminucionS = 10 * valorMinutos;

                stats.BajarAlimentacion();
                stats.BajarAnimo();
                stats.BajarSalud();

                actualizar.Actualizar();
            }
        }
    }

    private void OnApplicationQuit()
    {
        GuardarFecha();
    }

    public static void GuardarFecha()
    {
        PlayerPrefs.SetString("TiempoUltimo", DateTime.Now.ToString());

    }
}
