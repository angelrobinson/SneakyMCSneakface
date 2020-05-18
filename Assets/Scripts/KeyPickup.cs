using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour 
{
	public AudioSource source;

	void Start()
	{
		source = GetComponent <AudioSource> ();

	}

	void OnTriggerEnter (Collider other)
	{
		
		if (other.CompareTag ("Player"))
		{
			//play sound when item is picked up and destroy the object
			source.Play (); 
			Destroy (gameObject, 5f); 

			//set specific bool to true depending on what player "picks up"
			if (gameObject.CompareTag ("Finish"))
			{
				GameManager.instance.capsule = true;
			} else if (gameObject.CompareTag ("Purple"))
			{
				GameManager.instance.isPurple = true;
			}else
			{
				GameManager.instance.pickedUp = true;
			}

		}

	}
}
