using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
    public Transform[] spawnlocation;
    public GameObject[] whattoSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    void Update()
    {
        spawnerCreate();
    }

    void spawnerCreate()
    {
        whatToSpawnClone[0] = Instantiate(whattoSpawnPrefab[0], spawnlocation[0].transform.position, Quaternion.Euler(0,0,0))as GameObject;
    }
	
}
