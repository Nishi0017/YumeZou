using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDelete : MonoBehaviour

{
    public OnCollisionEnterSample oncollision;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oncollision.check)
        {
            Destroy(this.gameObject);
        }
    }
}
