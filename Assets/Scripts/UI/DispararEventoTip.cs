using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararEventoTip : MonoBehaviour
{
    [SerializeField] Eventos aparecer, desaparecer;
    [SerializeField] bool activo;
    
    public void ApareceryDesaparecer()
    {
        if (activo == false)
        {
            aparecer.FireEvent();
            activo = true;
        }
        else
        {
            desaparecer.FireEvent();
            activo = false;
        }
    }
    

}
