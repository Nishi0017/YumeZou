using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePowder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Color")
        {
            //isOn_color = true;
            GameObject obj = other.gameObject;
            Destroy(obj);
        }
    }
}
