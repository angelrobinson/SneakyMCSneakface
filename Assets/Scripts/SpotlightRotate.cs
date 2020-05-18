using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightRotate : MonoBehaviour 
{
	public GameObject spotlight;



	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{	
		//rotate the light
		spotlight.transform.RotateAround (spotlight.transform.position, Vector3.up, 10 * Time.deltaTime);
	}
}
