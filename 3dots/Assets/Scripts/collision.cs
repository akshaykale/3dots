using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {
	public int playerScore = 0;
	public GUIText scorePly;
	public GameObject gameOverMenu;
	public GameObject fakeGO_for_audio_gameover;

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Ball_")
		{
			if(col.gameObject.GetComponent<Renderer>().material.color==GetComponent<Renderer>().material.color)
			{
				playerScore = int.Parse(scorePly.text);
				playerScore+=1;
				Physics.gravity += new Vector3(0,-0.3f,0); 
				scorePly.text = ""+playerScore;

				Destroy(col.gameObject);

				if(playerScore>0)
					GetComponent<AudioSource>().Play();


				//InvokeRepeating("CreateBallClone", 2.0f, 2.0f);
			}else{
				fakeGO_for_audio_gameover.GetComponent<AudioSource>().Play();
				Time.timeScale = 0;
				gameOverMenu.SetActive(true);
				//Application.LoadLevel(Application.loadedLevel);
			}
		} 
	}



}
