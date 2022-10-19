using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwaController : MonoBehaviour
{
    private Rigidbody rb;
    private Transform tr;

    void Start()
    {

        rb = this.GetComponent<Rigidbody>();
        tr = gameObject.transform;
        float[] rnd = new float[3];
        for(int i = 0;i < rnd.Length; i++)
        {
            rnd[i] = Random.Range(0.0f, 3.0f);
        }
        Vector3 force = new Vector3(rnd[0], rnd[1], rnd[2]);
        rb.AddForce((force),ForceMode.Impulse);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            float rnd_x = Random.Range(0.0f, 5.0f);
            float rnd_y = Random.Range(0.0f, 5.0f);
            float rnd_z = Random.Range(0.0f, 5.0f);
            Debug.Log(rnd_x);
            Vector3 force = new Vector3(10, 0, 0);
            rb.AddForce((force),ForceMode.Impulse);
        }
    }
}
