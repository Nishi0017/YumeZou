using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnterSample : MonoBehaviour
{

    //OnCollisionEnter()
    private void OnCollisionEnter(Collision collision)
    {
        //Sphere���Փ˂����I�u�W�F�N�g��Plane�������ꍇ
        if (collision.gameObject.name == "Plane")
        {
            //�F�����ɕω�������
            GetComponent<Renderer>().material.color = Color.black;
            Destroy(this.gameObject);
        }
    }
}
