using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpaceship : MonoBehaviour { 

    public GameObject Spaceship;
public int xPos;
public int zPos;
public int SpaceshipCount;

   

    // Start is called before the first frame update
    void Start()
    {
    StartCoroutine(SpaceshipDrop());
        
    }
   
   IEnumerator SpaceshipDrop()
{
    while (SpaceshipCount < 20)
    {
        xPos = Random.Range(69, 102);
        zPos = Random.Range(-25, 13);
        Instantiate(Spaceship, new Vector3(xPos, 5, zPos), Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        SpaceshipCount += 1;
    }
}

  
}
