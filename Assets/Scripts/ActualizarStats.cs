using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActualizarStats : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI salud, alimentacion, animo;
    [SerializeField] Estadisticas stats;
    [SerializeField] Eventos actualizar;
    // Start is called before the first frame update
    void Start()
    {
        actualizar.GEvent += Actualizar;
        Actualizar();
    }
    public void Actualizar()
    {
        salud.text = stats.salud.ToString();
        alimentacion.text = stats.alimentacion.ToString();
        animo.text = stats.animo.ToString();
    }
    private void OnDestroy()
    {
        actualizar.GEvent -= Actualizar;
    }

}
