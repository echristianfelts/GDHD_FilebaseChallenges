using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class _36_IntroNav_MeshAI : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform goal;

    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    // Update is called once per frame
    void Update()
    {
       
        

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag != "floor")
        {
            other.GetComponent<Renderer>().material.color = new Color(0f, 1f, 0f, 1f);
        }
    }
}
