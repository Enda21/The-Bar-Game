using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    private float baseAngle = 0.0f;


    //detecs first touch
    void OnMouseDown()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);

        pos = Input.mousePosition - pos;
        baseAngle = Mathf.Atan2(pos.x, pos.z) * Mathf.Rad2Deg;
        baseAngle = Mathf.Atan2(transform.right.x, transform.right.z) * Mathf.Rad2Deg;
    }
    //hold touch and rotate
    void OnMouseDrag()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        pos = Input.mousePosition - pos;
        float ANG = Mathf.Atan2(pos.x, pos.z) * Mathf.Rad2Deg - baseAngle;
        transform.rotation = Quaternion.AngleAxis(ANG, Vector3.forward);

    }

}
