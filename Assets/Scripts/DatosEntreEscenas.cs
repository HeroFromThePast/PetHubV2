using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DatosEntreEscenas : MonoBehaviour
{
    public Estadisticas stats;
    public float salud, animo, alimentacion;
    private void Awake()
    {
        stats = GameObject.FindGameObjectWithTag("Player").GetComponent<Estadisticas>();
        Debug.Log("si esta en cada escena");
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
    }

    public void GuardarStats()
    {
        salud = stats.salud;
        animo = stats.animo;
        alimentacion = stats.alimentacion;
        Debug.Log("si guardo");
    }
    

}
