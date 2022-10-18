using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSleep : MonoBehaviour
{
    Camera mainCamera;
    [SerializeField] Estadisticas stats;
    [SerializeField] Eventos actualizar;
    [SerializeField] PetBehaviour petBehaviour;
    public Transform cama;
    public bool sleepTime = false;

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
                if (hit.transform.CompareTag("Cama") && stats.animo < 99) 
                {
                    Debug.Log(this.tag);                
                    sleepTime = true;
                    petBehaviour.UpdateIndex();             
                }
            }
        }
    }


}

