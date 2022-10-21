using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oto : MonoBehaviour
{
    public AudioClip se;
    public kumo Trigger;
    void Start()
    {
        
    }

    // Update is called once per frame
   
    void Update()
    {
       
    }
     void OnCollisionEnter(Collision col)
    {
        AudioSource.PlayClipAtPoint(se, transform.position);
    }
}
