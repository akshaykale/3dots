using UnityEngine;
using System.Collections;

public class button_handeler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void StartGame(){
		Application.LoadLevel ("tri");
	}

	public void MainMenu(){
		Application.LoadLevel ("MainMenu");
	}


	public void ExitGame(){
		Application.Quit ();
	}
	public void PauseGame(){
		if (Time.timeScale == 0.0) {//play
			Time.timeScale = 1.0f;	
			//text_pause.text = "Pause";
			
		} else {//pause
			//text_pause.text = "Play";
			//pauseMenu.SetActive(false);
			Time.timeScale = 0.0f;
			
		}

	}
	public void Retry(){
		Application.LoadLevel ("tri");
		Time.timeScale = 1;
		Physics.gravity = new Vector3 (0,-9.8f,0);
	}


}
