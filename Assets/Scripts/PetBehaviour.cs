using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PetBehaviour : MonoBehaviour
{
    [SerializeField] TMP_Text nombre;
    [SerializeField] DogSleep dogSleep;
    [SerializeField] Estadisticas stats;
    [SerializeField] DragObjects[] dragobj;
    [SerializeField] Eventos actualizar;
     //[SerializeField] Eventos propEntregado;
    NavMeshAgent agent;
    [SerializeField] public Transform[] waypoints;
    [SerializeField] int waypointIndex;
    [SerializeField] float stoppedTime = 0, posChangeCount = 0;
    Vector3 target;
    [SerializeField] float timer;
    [SerializeField] ManagerEscenarios managerEscenarios;
    

    [Header("Animacion")]
    [SerializeField] Animator animator;
    //[SerializeField] string condicion;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        nombre.text = PlayerPrefs.GetString("NombrePerro"); 

    }
    private void Start()
    {
        //propEntregado.GEvent += UpdateDestination;
        Debug.Log(System.DateTime.Now);
        //waypointIndex = Random.Range(0, waypoints.Length);
        UpdateDestination();
        //animator.SetBool(condicion, false);
        this.gameObject.transform.position = new Vector3(0, 0, 0);
    }

    private void Update()
    {
        if(dogSleep.sleepTime == true)
        {
            target = waypoints[8].position;
        }
        if (stats.salud < 50 || stats.alimentacion < 50 || stats.animo < 50)
        {
            animator.SetBool("IsHappy", false);
        }
        else animator.SetBool("IsHappy", true);

        if (Vector3.Distance(transform.position, target) <= 0.1f && dogSleep.sleepTime == false)
        {
            
            animator.SetBool("IsWalking", false);



            if(posChangeCount == 1)
            {
                animator.SetTrigger("Sniff");
            }
            if(posChangeCount == 2)
            {
                animator.SetTrigger("Scratch");

            }
            if (posChangeCount == 3)
            {
                animator.SetTrigger("Shake");
              
            }
            if (posChangeCount == 4)
            {
                animator.SetTrigger("Hear Something");
                posChangeCount = 0;
            }


            timer += Time.deltaTime;
            if (timer >= stoppedTime)
            {
                UpdateIndex();
                timer = 0;
            }
        }
        else if (Vector3.Distance(transform.position, target) <= 0.1f && dogSleep.sleepTime == true)
        {
         
            posChangeCount = 0;
    
            animator.SetBool("IsSleeping", true);
            animator.SetBool("IsWalking", false);

            stats.animo += Time.deltaTime * 2;
            actualizar.FireEvent();
            if (stats.animo >= 100)
            {
                stats.animo = 100.0f;
                dogSleep.sleepTime = false;
                animator.SetBool("IsSleeping", false);
                UpdateIndex();
            }

        }
        else if (dragobj[0].estaArrast == true || dragobj[1].estaArrast == true || dragobj[2].estaArrast == true)
        {
            target = waypoints[15].position;
            agent.SetDestination(target);

        }
        else if (dragobj[0].estaArrast == false || dragobj[1].estaArrast == false || dragobj[2].estaArrast == false && dogSleep.sleepTime == false)
        {
            UpdateIndex();
        }

        
        /*
        if (dragobj[0].estaArrast == true || dragobj[1].estaArrast == true || dragobj[2].estaArrast == true)
        {
            animator.SetBool(condicion, true);
        }
       // else animator.SetBool(condicion, false);*/



    }


    public void UpdateIndex()
    {
        //transform.position = target;
        
        int actualIndex;

        actualIndex = waypointIndex;
        if (timer >= stoppedTime)
        {
            if (SceneManager.GetActiveScene().name == "Main")
            {
                waypointIndex = Random.Range(0, 6);
                do
                {
                    waypointIndex = Random.Range(0, 6);
                }
                while (waypointIndex == actualIndex);
            }
            else if (SceneManager.GetActiveScene().name == "Sala")
            {
                waypointIndex = Random.Range(5, 11);
                do
                {
                    waypointIndex = Random.Range(5, 11);
                }
                while (waypointIndex == actualIndex);
            }
            else if (SceneManager.GetActiveScene().name == "Patio")
            {
                waypointIndex = Random.Range(10, 16);
                do
                {
                    waypointIndex = Random.Range(10, 16);
                }
                while (waypointIndex == actualIndex);
            }
            


                UpdateDestination();

        }
        else if (dogSleep.sleepTime == true)
        {
            waypointIndex = 8;
            if (animator.GetBool("IsWalking") == true)
            {
                UpdateDestination();
            }
            else
            {
                timer += Time.deltaTime;
                if (timer >= stoppedTime)
                {
                    UpdateDestination();
                    timer = 0;
                }
            }
            

            
           
        }
    }
    public void UpdateDestination()
    {
        
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
        animator.SetBool("IsWalking", true);
        posChangeCount++;
        stoppedTime = Random.Range(4, 8);
    }

}
