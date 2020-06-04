using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item; 

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }
   void PickUp ()

    {
        
        Debug.Log("Picking up " + item.name);
        // Add to inventory
        bool wasPickedup = Inventory.instance.Add(item);

        if(wasPickedup)
             Destroy(gameObject);
        
        
    }
}
