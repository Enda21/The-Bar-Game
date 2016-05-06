using UnityEngine;
using System.Collections;

public class Beer : MonoBehaviour
{
    private float dist;
    private bool dragging = false;
    private Vector3 offset;
    private Transform toDrag;
    public GameObject beer;



    void Update()
    {


        if (Input.touchCount != 1)
        {
            dragging = false;
            return;
        }

        Touch touch = Input.touches[0];
        Vector3 pos = touch.position;

        if (touch.phase == TouchPhase.Began)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(pos);
            if (Physics.Raycast(ray, out hit) && (hit.collider.tag == "beer"))
            {
                beer = hit.collider.gameObject;
                toDrag = hit.transform;
                Debug.Log("beer");
                beer.GetComponent<Renderer>().material.color = Color.red;
                dragging = true;
            }


            if (dragging == true)
            {
                print("check2");
                beer.GetComponent<pull>().enabled = true;
                
            }
            else
            {
                print("check1");
                beer.GetComponent<pull>().enabled = false;
                
            }
        }

        if (dragging && (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled))
        {
            dragging = false;
        }

    }

}

