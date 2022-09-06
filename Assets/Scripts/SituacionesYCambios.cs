using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Situacion")]
public class SituacionesYCambios : ScriptableObject
{
    [SerializeField] string nombreSituacion;
    [SerializeField] float aS, aA, aAl,dS,dA,dAl;
    
    
    

    // Start is called before the first frame update
    

    public void AlterarStats(Estadisticas mascota)
    {
        
            mascota.aumentoA = aA;
            mascota.aumentoAl = aAl;
            mascota.aumentoS = aS;
            mascota.disminucionA = dA;
            mascota.disminucionAl = dAl;
            mascota.disminucionS = dS;
        
    }
    
}
