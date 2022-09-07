using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estadisticas : MonoBehaviour
{
    static Estadisticas instance;
    public static Estadisticas Instance
    {
        get => instance;
    }
     public float salud, alimentacion, animo;
    
    [SerializeField] Eventos subirA, subirAl, subirS, bajarA, bajarAl, bajarS;
    public float aumentoS,aumentoAl,aumentoA,disminucionS, disminucionAl, disminucionA;

    private void Start()
    {
        //salud = 100;
        //hambre = 1;
        //animo = 100;
        instance = this;
        subirA.GEvent += SubirAnimo;
        subirAl.GEvent += SubirAlimentacion;
        subirS.GEvent += SubirSalud;
        bajarA.GEvent += BajarAnimo;
        bajarAl.GEvent += BajarAlimentacion;
        bajarS.GEvent += BajarSalud;
    }
    public void SubirSalud()
    {
        salud += aumentoS;
        if (salud > 100)
        {
            salud = 100;
        }
    }
    public void SubirAlimentacion()
    {
        alimentacion += aumentoAl;
        if (alimentacion > 100)
        {
            alimentacion = 100;
        }
    }
    public void SubirAnimo()
    {
        animo += aumentoA;
        if (animo > 100)
        {
            animo = 100;
        }
    }
    public void BajarSalud()
    {
        salud -= disminucionS;
        if (salud < 1)
        {
            salud = 1;
        }
    }
    public void BajarAlimentacion()
    {
        alimentacion -= disminucionAl;
        if (alimentacion < 1)
        {
            alimentacion = 1;
        }
    }
    public void BajarAnimo()
    {
        animo -= disminucionA;
        if (animo < 1)
        {
            animo = 1;
        }
    }
    private void OnDestroy()
    {
        subirA.GEvent -= SubirAnimo;
        subirAl.GEvent -= SubirAlimentacion;
        subirS.GEvent -= SubirSalud;
        bajarA.GEvent -= BajarAnimo;
        bajarAl.GEvent -= BajarAlimentacion;
        bajarS.GEvent -= BajarSalud;
    }
}
