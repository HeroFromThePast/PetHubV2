using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSituaciones : MonoBehaviour
{
    [SerializeField] SituacionesYCambios[] situaciones;
    [SerializeField] Eventos recibirPedigree, recibirPollo, recibirChocolate,alterarStats,actualizarStats;
    [SerializeField] Estadisticas mascota;
    void Start()
    {
        recibirPedigree.GEvent += Pedigree;
        recibirPollo.GEvent += Pollo;
        recibirChocolate.GEvent += Chocolate;
    }

    void Pedigree()
    {
        situaciones[0].AlterarStats(mascota);
        alterarStats.FireEvent();
        actualizarStats.FireEvent();
    }
    void Pollo()
    {
        situaciones[1].AlterarStats(mascota);
        alterarStats.FireEvent();
        actualizarStats.FireEvent();
    }
    void Chocolate()
    {
        situaciones[2].AlterarStats(mascota);
        alterarStats.FireEvent();
        actualizarStats.FireEvent();
    }

    private void OnDestroy()
    {
        recibirPedigree.GEvent -= Pedigree;
        recibirPollo.GEvent -= Pollo;
        recibirChocolate.GEvent -= Chocolate;
    }
}
