using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Trigger : MonoBehaviour
{

    public GameObject LangsamTrigger;
    public int xPos;
    public int zPos;
    public int TriggerCount;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpaceshipDrop());

    }


    IEnumerator SpaceshipDrop()
    {
        while (TriggerCount < 2)
        {
            xPos = Random.Range(69, 102);
            zPos = Random.Range(-25, 13);
            Instantiate(LangsamTrigger, new Vector3(xPos, 4, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            TriggerCount += 1;
        }
    }


}
