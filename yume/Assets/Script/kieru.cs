using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kieru : MonoBehaviour
{
	public GameObject[] Gene;
	public GameObject[] startExsit;

	void OnCollisionEnter(Collision collision)
	{
		
		if (collision.gameObject.tag == "floor")
		{
            Debug.Log("‚ ‚½‚Á‚½");
            Destroy(this.gameObject);
		}
	}
}
