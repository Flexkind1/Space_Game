using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class playermotor : MonoBehaviour
{

    Transform target; // 
    NavMeshAgent agent; // 

    void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
            FaceTarget();
        }
    }

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

   public void MovetoPoint (Vector3 point) 
    {
        agent.SetDestination(point);
    }

    // bewegt Spieler zu angeglicktem Interactable
    public void FollowTarget (Interactable newTarget)
    {
        // damit Character nicht erst im Objekt stoppt, sondern davor
        agent.stoppingDistance = newTarget.radius * .4f;
        agent.updateRotation = false;
        target = newTarget.interactionTransform;
    }

    // hört auf den Spieler zum angeglickten Object / Interactable zu bewegen,
    // wenn angekommen
    public void StopFollowingTarget()
    {
        // wenn man die Bewegung abbricht, 
        agent.stoppingDistance = 0f;
        agent.updateRotation = true;

        target = null;
    }

    void FaceTarget()
    {
        // gibt die Richtung an (zu Target gerichtet)
        Vector3 direction = (target.position - transform.position).normalized;
        // wie Character rotiert werden muss, um in diese Richtung zu zeigen (! kein Richtungswechsel in y richtung)
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.z));
        // ~ Interpolation für "smootheres" Drehen
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }
}
