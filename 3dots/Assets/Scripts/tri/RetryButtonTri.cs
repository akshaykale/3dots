using UnityEngine;
using System.Collections;

public class RetryButtonTri : MonoBehaviour {

	void OnMouseDown(){
		Application.LoadLevel ("tri");
		Time.timeScale = 1;
		Physics.gravity = new Vector3 (0,-9.8f,0);
	}
}
