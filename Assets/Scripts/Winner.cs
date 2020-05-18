using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		//if the player has picked up the "secret files" and crosses this trigger they win
		if (GameManager.instance.capsule == true)
		{
			GameManager.instance.source.clip = GameManager.instance.win;
			GameManager.instance.source.Play ();
			GameManager.instance.disableCamera (GameManager.instance.fps);
			GameManager.instance.ShowCamera (GameManager.instance.winner);//load win scene
			Debug.Log ("You Win!");

		}
	}


}
