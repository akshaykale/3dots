using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	void OnMouseDown(){
		Application.LoadLevel ("MainMenu");
		Time.timeScale = 1;
		Physics.gravity = new Vector3 (0,-9.8f,0);
	}
}
