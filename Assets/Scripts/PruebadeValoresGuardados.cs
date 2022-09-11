using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebadeValoresGuardados : MonoBehaviour
{
    [SerializeField] string variableTesteandose;
    [SerializeField] bool activo;
    void Awake()
    {
        if (activo == true)
        {
            PlayerPrefs.SetInt(variableTesteandose, 1);
        }
        else
        {
            PlayerPrefs.SetInt(variableTesteandose, 0);
        }
        
    }

    
}
