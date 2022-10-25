using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwaController : MonoBehaviour
{
    private GameObject atariObj;
    private atari atariScri;

    private Rigidbody rb;

    void Start()
    {
        atariObj = transform.parent.gameObject;
        atariScri = atariObj.GetComponent<atari>();
        GetComponent<Renderer>().material.color = atariScri.objColor;

        gameObject.transform.parent = null;

        GameObject cloudBox = GameObject.Find("CloudBox");
        this.gameObject.transform.parent = cloudBox.gameObject.transform;

        rb = this.GetComponent<Rigidbody>();

        float rnd_x = Random.Range(-1.0f, 1.0f);
        float rnd_y = Random.Range(-1.0f, 1.0f);
        float rnd_z = Random.Range(-1.0f, 1.0f);
        Debug.Log(rnd_x + "x");
        Debug.Log(rnd_y + "y");
        Debug.Log(rnd_z + "z");

        Vector3 force = new Vector3(rnd_x, rnd_y, rnd_z);
        rb.AddForce((force), ForceMode.Impulse);

        StartCoroutine("ScaleUp");


    }

    // Update is called once per frame
    void Update()
    {


    }
    IEnumerator ScaleUp()
    {
        for (float i = 15; i < 50; i += 1.0f)
        {
            this.transform.localScale = new Vector3(i, i, i);
            yield return new WaitForSeconds(0.1f);
        }
    }
}


