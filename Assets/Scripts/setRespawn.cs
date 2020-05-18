using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setRespawn : MonoBehaviour 
{
	private AudioSource source;

	// Use this for initialization
	void Start () 
	{
		source = GetComponent <AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter (Collider other)
	{
		//if player crosses the save point, set the respawn point
		if (other.CompareTag ("Player"))
		{

			source.Play ();
			
			switch (gameObject.tag)

			{
			case "Blue":
				GameManager.instance.respawn = GameManager.instance.bSpawn.transform;
				break;
			case "Green":
				GameManager.instance.respawn = GameManager.instance.gSpawn.transform;
				break;
			case "Orange":
				GameManager.instance.respawn = GameManager.instance.oSpawn.transform;
				break;
			case "Purple":
				GameManager.instance.respawn = GameManager.instance.pSpawn.transform;
				break;
			case "Red":
				GameManager.instance.respawn = GameManager.instance.rSpawn.transform;
				break;
			case "Yellow":
				GameManager.instance.respawn = GameManager.instance.ySpawn.transform;
				break;

			}
		}
	}
}
