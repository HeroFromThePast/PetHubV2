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
    
    [SerializeField] Eventos alterarStats,subirA,subirAl,subirS,bajarA,bajarAl,bajarS;
    public float aumentoS,aumentoAl,aumentoA,disminucionS, disminucionAl, disminucionA;

    private void Start()
    {
        
        instance = this;
        alterarStats.GEvent += AlterarStats;
        subirA.GEvent += SubirAnimo;
        subirAl.GEvent += SubirAlimentacion;
        subirS.GEvent += SubirSalud;
        bajarA.GEvent += BajarAnimo;
        bajarAl.GEvent += BajarAlimentacion;
        bajarS.GEvent += BajarSalud;
    }
    void AlterarStats()
    {
        SubirSalud();
        SubirAlimentacion();
        SubirAnimo();
        BajarSalud();
        BajarAlimentacion();
        BajarAnimo();
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
        if (salud < 10)
        {
            salud = 10;
        }
    }
    public void BajarAlimentacion()
    {
        alimentacion -= disminucionAl;
        if (alimentacion < 10)
        {
            alimentacion = 10;
        }
    }
    public void BajarAnimo()
    {
        animo -= disminucionA;
        if (animo < 10)
        {
            animo = 10;
        }
    }
    private void OnDestroy()
    {
        alterarStats.GEvent -= AlterarStats;
        subirA.GEvent -= SubirAnimo;
        subirAl.GEvent -= SubirAlimentacion;
        subirS.GEvent -= SubirSalud;
        bajarA.GEvent -= BajarAnimo;
        bajarAl.GEvent -= BajarAlimentacion;
        bajarS.GEvent -= BajarSalud;
    }
}
