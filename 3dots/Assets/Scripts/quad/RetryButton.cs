using UnityEngine;
using System.Collections;

public class RetryButton : MonoBehaviour {

	void OnMouseDown(){
		Application.LoadLevel ("quad");
		Time.timeScale = 1;
		Physics.gravity = new Vector3 (0,-9.8f,0);
	}
}
