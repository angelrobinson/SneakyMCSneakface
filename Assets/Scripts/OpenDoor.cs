using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour 
{
	public AudioSource source;
	
	// Use this for initialization
	void Start () 
	{
		source = GetComponent <AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider other)
	{
		
		if (other.CompareTag ("Player"))
		{
			source.Play ();
			//if picked up is false and  need to open unlocked door
			switch (gameObject.tag)

			{
			case "Purple":
				if (GameManager.instance.isPurple == true)
				{
					Destroy (GameObject.FindWithTag ("PurpleDoor"));//done
				}
				break;
			case "Key":
				Destroy (GameObject.FindWithTag ("KeyDoor"));//done
				break;
			case "Silver":
				Destroy (GameObject.FindWithTag ("SilverDoor"));//done
				break;

			}
			
			//open locked doors
			if (GameManager.instance.pickedUp == true)
			{
				
				switch (gameObject.tag)

				{
				case "Blue":
					Destroy (GameObject.FindWithTag ("BlueDoor"));//done
					break;
				case "Green":
					Destroy (GameObject.FindWithTag ("GreenDoor"));//done
					break;
				case "Orange":
					Destroy (GameObject.FindWithTag ("OrangeDoor"));//done
					break;
				case "Red":
					Destroy (GameObject.FindWithTag ("RedDoor"));
					break;
				case "Yellow":
					Destroy (GameObject.FindWithTag ("YellowDoor"));//done
					break;
				case "Black":
					Destroy (GameObject.FindWithTag ("BlackDoor"));//done
					break;
				case "Silver":
					Destroy (GameObject.FindWithTag ("SilverDoor"));//done
					break;
				
				}

				GameManager.instance.pickedUp = false;
			}




		}

	}
}
