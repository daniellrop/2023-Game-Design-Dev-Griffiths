using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray movePositon = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(movePositon, out var hitInfo))
            {
                agent.SetDestination(hitInfo.point);
            }
        }
}
}
