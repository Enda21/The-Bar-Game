using UnityEngine;
using System.Collections;

public class pull : MonoBehaviour {
    public float speed = 0.1f;
    protected bool letplay = true;
    public ParticleSystem beer;
   
  
    // Update is called once per frame
    void Update()
    {
        //float roll =  Input.acceleration.x;
        float pull = Input.acceleration.z;
        float push = Input.acceleration.y;
        Debug.Log(pull);

        transform.Translate(0, 0, -pull * speed);
        transform.Translate(0, 0, push * speed);
        
        if(letplay)
        {
            if (!beer.isPlaying)
            {
                beer.GetComponent<ParticleSystem>().Play();
            }
        }
        else
        {
            if (beer.GetComponent<ParticleSystem>().isPlaying)
            {
                beer.GetComponent<ParticleSystem>().Stop();
            }
        }
        
    }
    


}
