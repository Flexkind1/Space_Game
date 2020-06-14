using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boostSpawn1 : MonoBehaviour
{

    public ChangePlayerSpeedSchnell[] AllBoostZones;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("DestroyBoosts", 2, 4);
        InvokeRepeating("SpawnBoosts", 2, 4);
    }

    void DestroyBoosts()
    {
        for (int i = 0; i < 6; i++)
        {
            int randomIndex = Random.Range(0, AllBoostZones.Length);
            AllBoostZones[randomIndex].GetComponent<MeshRenderer>().enabled = false;
            AllBoostZones[randomIndex].GetComponent<BoxCollider>().enabled = false;
        }
    }

    void SpawnBoosts()
    {
        for (int i = 0; i < 6; i++)
        {
            int randomIndex = Random.Range(0, AllBoostZones.Length);
            AllBoostZones[randomIndex].GetComponent<MeshRenderer>().enabled = true;
            AllBoostZones[randomIndex].GetComponent<BoxCollider>().enabled = true;
        }
    }
}
