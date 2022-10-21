using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public static class Utilities{
	public static IEnumerator DelayMethod(float waitTime,Action action){
		yield return new WaitForSeconds (waitTime);
		action ();
	}
}


public class otamesi : MonoBehaviour
{
    //public AudioClip catastoroph;
    public AudioSource auio;

    // Start is called before the first frame update
    void Start()
    {
        auio = GetComponent<AudioSource>();
        //GetComponent<AudioSource>().PlayOneShot(catastoroph);
        auio.Play();


    }

    // Update is called once per frame
    void Update()
    {
        
        
        StartCoroutine (Utilities.DelayMethod (1f, () => {auio.Stop();}));
    }
}
