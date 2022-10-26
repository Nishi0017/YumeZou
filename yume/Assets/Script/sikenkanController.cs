using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sikenkanController : MonoBehaviour
{
    private float angle_x;
    private float angle_z;
    public PowderController powderController;
    public bool flag = false;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        angle_x = transform.localEulerAngles.x;
        angle_z = transform.localEulerAngles.z;
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Color")
        {
            if(angle_x > 90 || angle_x < -90 || angle_z > 90 || angle_z < -90 && !flag)
            {
                powderController.Childeren();
                flag = true;
            }
            else
            {
                powderController.Parent();
                flag = false;
            }
        }
    }
}
