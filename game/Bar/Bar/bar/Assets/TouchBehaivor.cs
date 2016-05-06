using UnityEngine;
using System.Collections;

public class TouchBehaivor : MonoBehaviour
{
    private float dist;
    private bool dragging = false;
    private Vector3 offset;
    private Transform toDrag;
    public GameObject beer;
    public GameObject cocktail;
    public float speed =  0.1f;

    public bool isActive;
    void Start()
    {
        isActive = true;
    }
    
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
                beer = hit.collider.gameObject;
                Debug.Log("Here");
                toDrag = hit.transform;
                
             
                beer.GetComponent<Renderer>().material.color = Color.red;
                dragging = true;

            }
            if (isActive == true)
            {
                print("check2");
                beer.GetComponent<pull>().enabled = true;
                cocktail.GetComponent<Rotate>().enabled = false;
                isActive = false;
            }
            else
            {
                print("check1");
                beer.GetComponent<pull>().enabled = false;
                cocktail.GetComponent<Rotate>().enabled = true;
                isActive = true;
            }

        }
        
        if (dragging && (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled))
        {
            dragging = false;
        }
        
    }

   }
    
    