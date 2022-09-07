using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PetBehaviour : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] public Transform[] waypoints;
    [SerializeField] int waypointIndex;
    [SerializeField] float stoppedTime = 0;
    Vector3 target;
    [SerializeField] float timer;
    [SerializeField] ManagerEscenarios managerEscenarios;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();           
    }
    private void Start()
    {      
        Debug.Log(System.DateTime.Now);
        //waypointIndex = Random.Range(0, waypoints.Length);
        UpdateDestination();
    }

    private void Update()
    {
       if (Vector3.Distance(transform.position, target) <= 0.1f)
        {
            UpdateIndex();      
        }
    }

    
    
    public void UpdateIndex()
    {
        if (stoppedTime == 0)
        {
            stoppedTime = Random.Range(2, 9);
        }
        //transform.position = target;
        int actualIndex;  
        timer += Time.deltaTime;
        actualIndex = waypointIndex;
        if(timer >= stoppedTime)
        {
            if (managerEscenarios.escenariosActual == 0)
            {
                waypointIndex = Random.Range(0, 6);
                do
                {
                    waypointIndex = Random.Range(0, 6);
                }
                while (waypointIndex == actualIndex);
            }
            else if (managerEscenarios.escenariosActual == 1)
            {
                waypointIndex = Random.Range(5, 11);
                do
                {
                    waypointIndex = Random.Range(5, 11);
                }
                while (waypointIndex == actualIndex);
            }
            else if (managerEscenarios.escenariosActual == 2)
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
