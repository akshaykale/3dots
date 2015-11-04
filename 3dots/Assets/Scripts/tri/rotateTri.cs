using UnityEngine;
using System.Collections;

public class rotateTri : MonoBehaviour {

	private float ang = 0f;

	void Start () {
	
	}
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			ang =120;
		} else {
			ang = 0;
		}
		transform.Rotate (ang,0,0);
		//Vector3 an = new Vector3 (transform.rotation.x+ang, transform.rotation.y, transform.rotation.z);
		//transform.rotation = Mathf.LerpAngle (transform.rotation,an,Time.time);
	}

	void Rotatetri(){

	}

}
