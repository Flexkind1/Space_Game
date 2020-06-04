using UnityEngine.EventSystems;
using UnityEngine;

[RequireComponent(typeof(playermotor))]
public class playercontroller : MonoBehaviour
{
    public Interactable focus;

    public LayerMask movementMask;
    Camera cam;
    playermotor motor;

    void Start()
    {
        // Main-camera ist an den Spieler gebunden
        cam = Camera.main;
        motor = GetComponent<playermotor>();
    
    }

    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        // wenn linke Maustaste gedrückt ist
        if (Input.GetMouseButtonDown(0))
        {
            // wird ein Ray erzeugt
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // wenn der Ray "trifft" ?
            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {

                // bewegt den Spieler zu dem Punkt, den man angeklickt hat
                motor.MovetoPoint(hit.point);

                // stop focusing any objects
                RemoveFocus();
            }
        }


        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                //check if we hit an interactable 
                Interactable interactable = hit.collider.GetComponent<Interactable>();

              // If we did set it as our focus
              if (interactable != null)
                {
                    SetFocus(interactable);
                }
            }
        }
    }

    void SetFocus(Interactable newFocus)
    {
        // wenn der neue Fokus (angeklicktes) nicht der aktuelle Fokus ist, dann...
        if(newFocus != focus)
        {
            if (focus != null)
                focus.OnDefocused();

            focus = newFocus;
            motor.FollowTarget(newFocus);
        }

        
        newFocus.OnFocused(transform);
        //motor.MovetoPoint(newFocus.transform.position);
        
    }

    void RemoveFocus()
    {
        if(focus != null)
            focus.OnDefocused();

        focus = null;
        motor.StopFollowingTarget();
    }
}
