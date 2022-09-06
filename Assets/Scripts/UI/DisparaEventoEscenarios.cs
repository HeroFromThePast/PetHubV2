using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparaEventoEscenarios : MonoBehaviour
{
    [SerializeField] Eventos escenario,aparicion,desaparicion;
    [SerializeField] bool activo;
    void Start()
    {
        aparicion.GEvent += Aparicion;
        desaparicion.GEvent += Desaparicion;
    }

    public void CambioEscenario()
    {
        if (activo == true)
        {
            escenario.FireEvent();
            desaparicion.FireEvent();
        }
    }
    void Aparicion()
    {
        activo = true;
    }
    void Desaparicion()
    {
        activo = false;
    }
    private void OnDestroy()
    {
        aparicion.GEvent -= Aparicion;
        desaparicion.GEvent -= Desaparicion;
    }
}
