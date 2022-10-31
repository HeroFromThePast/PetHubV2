using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadisticasPorTiempo : MonoBehaviour
{
    private float timer;
    [SerializeField] ActualizarStats actualizar;
    [SerializeField] Estadisticas stats;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 30)
        {
            stats.disminucionA = 2;
            stats.disminucionAl = 2;
            stats.disminucionS = 2;
            stats.BajarAlimentacion();
            stats.BajarAnimo();
            stats.BajarSalud();

            actualizar.Actualizar();
            timer = 0;
        }
    }
}
