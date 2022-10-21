using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioClip se;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(se, transform.position);   
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
