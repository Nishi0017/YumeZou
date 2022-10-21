using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kumo : MonoBehaviour
{
    int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (num <= 50)
        {
            transform. localScale += new Vector3(10,10,10);
            num +=1;
        }
    }
}
