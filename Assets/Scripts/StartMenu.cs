using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour 
{	
	//public GameObject play, exit;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void StatGame()
	{
		SceneManager.LoadScene ("Warehouse");
	}

	public void ExitGame()
	{
		Application.Quit ();
	}

}
