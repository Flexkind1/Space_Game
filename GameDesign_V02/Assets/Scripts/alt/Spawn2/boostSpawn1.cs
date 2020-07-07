using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boostSpawn1 : MonoBehaviour
{

    public ChangePlayerSpeedSchnell[] AllBoostZones;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("RandomIndex", 1, 1);
        InvokeRepeating("DestroyBoosts", 1, 3);
        InvokeRepeating("SpawnBoosts", 2, 3);
    }



    /*void RandomIndex()
    {
        for (int apos = 0; apos < AllBoostZones.Length; apos++)
        {
            ChangePlayerSpeedSchnell tmp = AllBoostZones[apos];
            int r = Random.Range(apos, AllBoostZones.Length);
            AllBoostZones[apos] = AllBoostZones[r];
            AllBoostZones[r] = tmp;
        }

    }*/


    void DestroyBoosts()
    {

        for (int i = 0; i < 6; i++)
        {
            int randomIndex = Random.Range(0, AllBoostZones.Length);
           /* if (AllBoostZones[randomIndex].GetComponent<MeshRenderer>().enabled == true)
            {*/
                AllBoostZones[randomIndex].GetComponent<MeshRenderer>().enabled = false;
                AllBoostZones[randomIndex].GetComponent<CapsuleCollider>().enabled = false;
         //   }
                
        }
    }

    void SpawnBoosts()
    {
        for (int i = 0; i < 6; i++)
        {
            int randomIndex = Random.Range(0, AllBoostZones.Length);
           // if (AllBoostZones[randomIndex].GetComponent<MeshRenderer>().enabled == false)
           // {
                AllBoostZones[randomIndex].GetComponent<MeshRenderer>().enabled = true;
                AllBoostZones[randomIndex].GetComponent<CapsuleCollider>().enabled = true;
           // }
            
           
        }
    }


}
