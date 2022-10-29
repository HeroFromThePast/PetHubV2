using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SubirEstadisticas : MonoBehaviour
{
    Camera mainCamera;
    [SerializeField] Estadisticas stats;
    [SerializeField] ParticleSystem psInteractuar;
    [SerializeField] Eventos actualizar;

    Ray ray;
    RaycastHit hit;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Player"))
                {
                    psInteractuar.Play();
                }
                if (hit.transform.CompareTag("Player") == transform && stats.salud < 100) 
                {
                    psInteractuar.Play();
                    Debug.Log(this.tag);
                    stats.salud += 5;
                    actualizar.FireEvent();
                    if(stats.salud > 100)
                    {                 
                        stats.salud = 100;
                    }
                }
            }
        }
    }

    
}
