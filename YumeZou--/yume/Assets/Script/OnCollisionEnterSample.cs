using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnterSample : MonoBehaviour
{
    public bool check = false;


    //OnCollisionEnter()
    private void OnCollisionEnter(Collision collision) { 
        //Sphere���Փ˂����I�u�W�F�N�g��Plane�������ꍇ
        if (this.gameObject.tag == "floor");
        {
            check = true;
            //�F�����ɕω�������
            GetComponent<Renderer>().material.color = Color.black;
            Destroy(this.gameObject);
        }
    }
}
