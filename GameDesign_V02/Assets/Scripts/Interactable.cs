using UnityEngine;

public class Interactable : MonoBehaviour
{
    // fragt ab ob button gedrückt ist oder nicht 
    private bool showText = false;

    // radius um Objekt innerhalb dessen man damit interagieren kann
    public float radius = 10f;

    public Transform interactionTransform;

    bool isFocus = false;
    Transform player;

    bool hasInteracted = false;

    // virtual => damit man für jedes Objekt einen anderen Code einfügen kann
    // alles unterhalb "public Virtual void Interact ()" ist quasi anzupassen für jedes Objekt
    public virtual void Interact()
    {
        Debug.Log("Interacting with" + transform.name);
    }

    void Update()
    {
        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            if(distance <= radius)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }

    public void OnFocused (Transform PlayerTransform)
    {
        isFocus = true;
        player = PlayerTransform;
        hasInteracted = false;
        if (!showText)
            showText = true;
    }

    public void OnDefocused()
    {
        isFocus = false;
        player = null;
        hasInteracted = true;
    }
    void OnDrawGizmosSelected()
    {

        if (interactionTransform == null)
            interactionTransform = transform; 

        // damit man im Unity Scene view sieht, in welchem Radius man mit Objekt interagieren kann
        // wird angezeigt durch gelbes wireframe um Objekt
    
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }

    // Textanzeige
    void OnGUI()
    {
        if (showText)
        {
            if (GUI.Button(new Rect(300 , 250, 100, 20), "Text"))
                showText = false;
        }
    }
}
