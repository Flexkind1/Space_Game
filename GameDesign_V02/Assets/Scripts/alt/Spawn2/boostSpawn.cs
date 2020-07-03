using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boostSpawn : MonoBehaviour
{

    public ChangePlayerSpeed[] AllBoostZones;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("DestroyBoosts", 1, 0.75f);
        InvokeRepeating("SpawnBoosts", 1, 0.75f);
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
