using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnterSample : MonoBehaviour
{

    //OnCollisionEnter()
    private void OnCollisionEnter(Collision collision)
    {
        //Sphereが衝突したオブジェクトがPlaneだった場合
        if (collision.gameObject.name == "Plane")
        {
            //色を黒に変化させる
            GetComponent<Renderer>().material.color = Color.black;
            Destroy(this.gameObject);
        }
    }
}
