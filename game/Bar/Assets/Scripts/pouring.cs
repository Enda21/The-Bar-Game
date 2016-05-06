using UnityEngine;
using System.Collections;

public class pouring: MonoBehaviour
{
    public float max_beer = 100f;
    public float cur_beer = 0f;
    public GameObject beerbar;


void Start()
{
    cur_beer = 0f;
        InvokeRepeating("increase", 1f, 1f);
}
void increase()
    {
        cur_beer += 4f;
        float clac_beer = cur_beer / max_beer;
        SetBeer(clac_beer);
    }
    void SetBeer (float mybeer)
    {
        beerbar.transform.localScale = new Vector3(mybeer, beerbar.transform.localScale.x, beerbar.transform.localScale.z); 
    }

}