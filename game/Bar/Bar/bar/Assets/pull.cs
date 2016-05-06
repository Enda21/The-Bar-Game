using UnityEngine;
using System.Collections;

public class pull : MonoBehaviour
{
    public float speed = 0.1f;



    // Update is called once per frame
    void Update()
    {


        float pull = Input.acceleration.z;
        Debug.Log(pull);
        transform.Translate(0, 0, pull * speed);
    }

}