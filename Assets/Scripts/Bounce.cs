using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour 
{
	
	private AnimationCurve curve;

	// Use this for initialization
	void Start () 
	{
		//animates the keys to move in the air.  
		//Green and purple are on top of othe objects and not just on the floor, so i had to create a switch case for them
		switch (gameObject.tag)

		{
	
		case "Green":
			curve = new AnimationCurve(new Keyframe(8, 8), new Keyframe(9, 9));
			break;
		
		case "Purple":
			curve = new AnimationCurve(new Keyframe(10, 10), new Keyframe(11, 11));
			break;
		
		
		default:
			curve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1,1));
			break;
		}

		//loops the movement to imitate bouncing
		curve.preWrapMode = WrapMode.PingPong;
		curve.postWrapMode = WrapMode.PingPong; 
	}
	
	// Update is called once per frame
	void Update () 
	{

		transform.position = new Vector3(transform.position.x, curve.Evaluate(Time.time), transform.position.z);

	}
}
