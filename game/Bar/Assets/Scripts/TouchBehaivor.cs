using UnityEngine;
using System.Collections;


public class TouchBehaivor : MonoBehaviour
{
    private float dist;
    private bool dragging = false;
    private Vector3 offset;
    private Transform toDrag;
    public GameObject obj;
    public float speed =  0.1f;

    public bool isActive;
    //static SceneManager Instance;
   
    void Start()
    {
        isActive = false;

    }
    public void OnGUI()
    {
        if (GUI.Button(new Rect(390,5, 100, 100), "Reset"))
            Application.LoadLevel("bar");

        if (GUI.Button(new Rect(0,5, 100, 100), "Exit"))
            Application.Quit();
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

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Draggable")
                {
                    if (isActive == true)
                    {
                        print("check2");
                        obj.GetComponent<pull>().enabled = true;
                        isActive = false;
                    }
                    else
                    {
                        print("check1");
                        obj.GetComponent<pull>().enabled = false;
                        isActive = true;
                    }
                }
                //obj = hit.collider.gameObject;
                Debug.Log("Here");
                //toDrag = hit.transform;
                
             
                //obj.GetComponent<Renderer>().material.color = Color.red;
                //dragging = true;

            }
            

        }
        
        if (dragging && (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled))
        {
            dragging = false;
        }
        
    }

   }
    
    