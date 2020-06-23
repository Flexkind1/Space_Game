using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTriggerZone : MonoBehaviour
{
    // Durch bool wird getestet, ob der Player mit dem Trigger kolliediert oder nicht.
    public bool isDamaging;
    // 10 Schaden jede Sekunde; Rechnung bezüglich Time.deltaTime
    public float damage = 10;

    
    // Sollte Player mit dem Trigger der Box kollidieren
    private void OnTriggerStay(Collider col)
    {
        // Wenn der Player mit dem Trigger der Box kollidiert, wird eine Nachricht gesendet: Take Damage
        // Wenn der Player mit der Box kolliediert, aber nicht mit dem Trigger, dann wird die Nachricht: Heal Damage gesendet.
        if (col.tag == "Player")
            col.SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);

        
    }

    
}
