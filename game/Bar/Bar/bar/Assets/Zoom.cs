using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour {

    public float zoomSpeed = 0.1f;
    public float orthoZoomSpeed = 0.1f;



    void Update()
    {
        if (Input.touchCount == 2)
        {
           

            //store  touches
            Touch touchzero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);
            //record touch postion 
            Vector2 touchZeroPrevPos = touchzero.position - touchzero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchzero.position - touchOne.position).magnitude;

            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

           if (Camera.main.orthographic)
            {

                Camera.main.orthographicSize += deltaMagnitudeDiff * orthoZoomSpeed;

                Camera.main.orthographicSize = Mathf.Max(Camera.main.orthographicSize,0.1f);
            }
            else
            {
                Camera.main.fieldOfView += deltaMagnitudeDiff * zoomSpeed;

                Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 0.1f, 179.9f);

                
            }
        }
    }
}
