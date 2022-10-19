using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detekuru: MonoBehaviour
{
    public atari Trigger ;
    public GameObject cloud ;
    private bool produceFlag = false ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Trigger.isOn == true && produceFlag == false)
        {
            Instantiate(cloud, new Vector3(0.0f,2.0f,0.0f),Quaternion.identity) ;
            produceFlag = true;
        }
    }
}
