using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atari : MonoBehaviour
{
    public bool isOn ;

    // Start is called before the first frame update
    private void Start()
    {
        isOn = false ;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision Collision)
    {
        isOn = true ;
    }

    
}
