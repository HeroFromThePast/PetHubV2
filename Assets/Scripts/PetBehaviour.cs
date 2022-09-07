using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PetBehaviour : MonoBehaviour
{
    [SerializeField] DragObjects dragO;
    private Vector3 iniPos;
    NavMeshAgent agent;
    [SerializeField] public Transform[] waypoints;
    [SerializeField] int waypointIndex;
    [SerializeField] float stoppedTime = 0;
    Vector3 target;
    [SerializeField] float timer;
    
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();           
    }
    private void Start()
    {
        Debug.Log(System.DateTime.Now);
        waypointIndex = Random.Range(0, waypoints.Length);
        UpdateDestination();
        iniPos = this.gameObject.transform.position;
    }

    private void Update()
    {
        if (dragO.estaArrast == false) { 
            if (Vector3.Distance(transform.position, target) <= 0.1f)
            {
                UpdateIndex();      
            }         
        }else
        {
            this.gameObject.transform.position = iniPos;
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
            waypointIndex = Random.Range(0, waypoints.Length);
            do
            {
                waypointIndex = Random.Range(0, waypoints.Length);
            }
            while(waypointIndex == actualIndex);

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
