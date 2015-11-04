using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	public float smooth = 10f;
	
	private float ang = 0f;

	void Start () 
	{   

	}
	
	void Update () 
	{
		if (Input.GetButtonDown ("Fire1")) {
			ang =-90;
		} else {
			ang = 0;
		}
		transform.Rotate (0,0,ang);


	}


}
