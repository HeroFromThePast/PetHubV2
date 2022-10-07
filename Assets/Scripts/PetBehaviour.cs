using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class PetBehaviour : MonoBehaviour
{
    [SerializeField] Estadisticas stats;
    [SerializeField] DragObjects[] dragobj;
    //[SerializeField] Eventos propEntregado;
    NavMeshAgent agent;
    [SerializeField] public Transform[] waypoints;
    [SerializeField] int waypointIndex;
    [SerializeField] float stoppedTime = 0;
    Vector3 target;
    float timer;
    [SerializeField] ManagerEscenarios managerEscenarios;

    [Header("Animacion")]
    [SerializeField] Animator animator;
    [SerializeField] string condicion;
    [SerializeField] GameObject[] alertas;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }
    private void Start()
    {
        //propEntregado.GEvent += UpdateDestination;
        Debug.Log(System.DateTime.Now);
        //waypointIndex = Random.Range(0, waypoints.Length);
        UpdateDestination();
        animator.SetBool(condicion, false);
        this.gameObject.transform.position = new Vector3(0, 0, 0);
    }

    private void Update()
    {
        if(stats.salud <= 60 || stats.alimentacion <=50 || stats.animo <= 50)
        {
            agent.speed = 4;
        }
        else if (stats.salud > 60 || stats.alimentacion > 50 || stats.animo > 50)
        {
            agent.speed = 8;
        }
        if (Vector3.Distance(transform.position, target) <= 0.1f )
        {
            UpdateIndex();      
        }
        else if (dragobj[0].estaArrast == true || dragobj[1].estaArrast == true || dragobj[2].estaArrast == true)
        {
            agent.SetDestination(waypoints[15].position);
            
        }
        else if(dragobj[0].estaArrast == false || dragobj[1].estaArrast == false || dragobj[2].estaArrast == false)
        {
            UpdateIndex();
        }

        if (dragobj[0].estaArrast == true || dragobj[1].estaArrast == true || dragobj[2].estaArrast == true)
        {
            animator.SetBool(condicion, true);
        }
        //else animator.SetBool(condicion, false);
        

        if (stats.salud <= 25)
        {
            alertas[0].SetActive(true);
        }
        else alertas[0].SetActive(false);
        if (stats.alimentacion <= 25)
        {
            alertas[1].SetActive(true);
        }
        else alertas[1].SetActive(false);
        if (stats.animo <= 25)
        {
            alertas[2].SetActive(true);
        }
        else alertas[2].SetActive(false);
    }

    
    
    public void UpdateIndex()
    {
        if (stoppedTime == 0)
        {
            stoppedTime = Random.Range(2, 5);
        }
        //transform.position = target;
        int actualIndex;  
        timer += Time.deltaTime;
        actualIndex = waypointIndex;
        if(timer >= stoppedTime)
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
            timer = 0;
        }
    }
    public void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
        stoppedTime = 0;
    }
    
}
