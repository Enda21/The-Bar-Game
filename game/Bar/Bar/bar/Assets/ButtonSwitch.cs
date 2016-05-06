using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonSwitch : MonoBehaviour {
    public GameObject hammer;
    public GameObject obj;
    public Image img;
    public bool isActivate;
    



	// Use this for initialization
	void Start ()
    {
        	
        isActivate = true;
        
    }
   
    public void hi()
    {
        print("hi");
    }
	
    public void activate()
    {
        if(isActivate == true)
        {
            print("check2");
            hammer.GetComponent<pull>().enabled = true;
            img.color = Color.red;
            isActivate = false;

        }
        else
        {
            print("check1");
            hammer.GetComponent<pull>().enabled = false;
            isActivate = true;
            img.color = Color.white;
        }
    }

    private void active() 
    {
        
            if(isActivate == false)
            {
                obj.GetComponent<Rotate>().enabled = true;
                obj.GetComponent<TouchBehaivor>().enabled = true;
                isActivate = true;
        }
            else
            {
                obj.GetComponent<Rotate>().enabled = false;
                obj.GetComponent<TouchBehaivor>().enabled = false;
                isActivate = false;
        }
            
        }

    }

