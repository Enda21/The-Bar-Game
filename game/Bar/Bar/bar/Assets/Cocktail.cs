using UnityEngine;
using System.Collections;

public class Cocktail : MonoBehaviour
{
    private float dist;
    private bool dragging = false;
    private Vector3 offset;
    private Transform toDrag;
    public GameObject cocktail;
    


   
   

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
            if (Physics.Raycast(ray, out hit) && (hit.collider.tag == "Draggable"))
            {
                cocktail = hit.collider.gameObject;
                toDrag = hit.transform;
                Debug.Log("cocktail");
                cocktail.GetComponent<Renderer>().material.color = Color.red;
                dragging = true;
               



            }
        
          

            if (dragging == true)
            {
                print("cocktail");
                cocktail.GetComponent<pull>().enabled = true;

            }
            else
            {
                print("notcocktail");
                cocktail.GetComponent<pull>().enabled = true;

            }
        }

        if (dragging && (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled))
        {
            dragging = false;
        }

    }

}

