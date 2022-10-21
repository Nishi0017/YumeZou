using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kieru : MonoBehaviour
{
	public GameObject Water;
	public GameObject[] Gene;
	public GameObject[] startExsit;

	void OnCollisionEnter(Collision collision)
	{
		
		if (collision.gameObject.tag == "floor")
		{
			for (int i = 0; i < Gene.Length; i++)
			{
				Gene[i].gameObject.SetActive(true);
				
			}
            for (int i = 0; i < startExsit.Length; i++)
            {
                startExsit[i].gameObject.SetActive(true);
            }
            Debug.Log("‚ ‚½‚Á‚½");
			Destroy(Water);
            Destroy(this.gameObject);
		}
	}
}
