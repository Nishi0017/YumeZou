using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kieru : MonoBehaviour
{
    public string target_tag;

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Sphere")
		{
			Destroy(collision.gameObject);
			
		}
	}
}
