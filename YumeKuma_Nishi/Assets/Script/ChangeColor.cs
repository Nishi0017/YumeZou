
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject obj;
    public Color objColor;

    void Update()
    {
        float dx = Input.GetAxis("Horizontal") * Time.deltaTime * 3;
        float dz = Input.GetAxis("Vertical") * Time.deltaTime * 3;
        transform.position = new Vector3(
        transform.position.x + dx, 0, transform.position.z + dz
        );
    }

    void OnCollisionEnter(Collision collision)
    {
        obj = collision.gameObject;
        objColor = obj.GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = objColor;
    }
}
