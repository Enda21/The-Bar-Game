using UnityEngine;
using System.Collections;

public class orderUp : MonoBehaviour {
    public Transform[] spawnlocation;
    public GameObject[] whattoSpawnPrefab;
    public GameObject[] whatToSpawnClone;
    

    void OnCollisionEnter(Collision col)
    { 
        if (col.gameObject.name == "Glass")
        {
            Destroy(col.gameObject);
        }
        else
            spawnerCreate();
    }
  

    void spawnerCreate()
    {
        whatToSpawnClone[0] = Instantiate(whattoSpawnPrefab[0], spawnlocation[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

}
