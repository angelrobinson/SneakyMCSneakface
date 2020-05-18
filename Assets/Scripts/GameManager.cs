using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	public static GameManager instance;

	public GameObject bkey,gkey,okey,pkey,rkey,ykey, key; //keys
	public GameObject pSave, gSave, bSave, oSave, ySave, rSave; //save points
	public GameObject gSpawn, pSpawn, bSpawn, oSpawn, ySpawn, rSpawn; //spawn points
	public GameObject player, playerPrefab;
	public bool pickedUp, capsule, isPurple;
	public Transform respawn;
	public AudioClip close, seen, win, loose;
	public AudioSource source;
	public int lives;

	public Camera fps, winner, loser; //camera game object



	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () 
	{
		
		source = GetComponent<AudioSource> ();
		pickedUp = capsule= isPurple = false;
		respawn = GetComponent <Transform> ();
		lives = 3;
		fps = GetComponent<Camera> ();
		winner = GetComponent<Camera> ();
		loser = GetComponent<Camera> ();


		//disableCamera (fps);
		disableCamera (winner);
		disableCamera (loser); 
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (lives == 0)
		{
			source.clip = loose;
			source.Play ();
			//load failure screen
			disableCamera (fps);
			ShowCamera (loser);
		}

		if (Input.GetKey (KeyCode.Escape))
		{
			Quit ();
		}
	}

	public void ShowCamera(Camera cam)
	{
		cam.gameObject.SetActive (true);
		cam.enabled = true;
	}

	public void disableCamera(Camera cam)
	{
		cam.enabled = false;
		cam.gameObject.SetActive (false);
	}

	public void Quit()
	{
		Application.Quit ();
	}

	public void Respawn()
	{
		player = Instantiate (playerPrefab, respawn.transform.position, Quaternion.identity);
	}


}
