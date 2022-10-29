using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwaController : MonoBehaviour
{
    public GameObject obj;
    public Color objColor;

    private Color myColor;
    private GameObject saveColor;
    private saveColor saveColorScri;
    private Rigidbody rb;

    void Start()
    {
        saveColor = transform.parent.gameObject;
        saveColorScri = saveColor.GetComponent<saveColor>();
        GetComponent<Renderer>().material.color = saveColorScri.colorSave;

        gameObject.transform.parent = null;

        GameObject cloudBox = GameObject.Find("CloudBox");
        this.gameObject.transform.parent = cloudBox.gameObject.transform;

        rb = this.GetComponent<Rigidbody>();

        float rnd_x = Random.Range(-1.0f, 1.0f);
        float rnd_y = Random.Range(-1.0f, 1.0f);
        float rnd_z = Random.Range(-1.0f, 1.0f);

        Vector3 force = new Vector3(rnd_x, rnd_y, rnd_z);
        rb.AddForce((force), ForceMode.Impulse);

        StartCoroutine("ScaleUp");


    }

    // Update is called once per frame
    void Update()
    {


    }


    private void OnTriggerEnter(Collider other)
    {
        string tag = other.gameObject.tag;
        if (tag == "Color" || tag == "Awa")
        {
            myColor = this.gameObject.GetComponent<Renderer>().material.color;
            obj = other.gameObject;
            objColor = obj.GetComponent<Renderer>().material.color;
            if (myColor != objColor)
                GetComponent<Renderer>().material.color = (myColor + objColor) / 2;
            if (tag == "Color")
                Destroy(other.gameObject);
        }
    }

    IEnumerator ScaleUp()
    {
        for (float i = 15; i < 30; i += 1.0f)
        {
            this.transform.localScale = new Vector3(i, i, i);
            yield return new WaitForSeconds(0.1f);
        }
    }
}


