using UnityEngine;
using System.Collections;

public class sphereCloning : MonoBehaviour {
	public GameObject nBall;
	public Material[] matList;
	GameObject Ball;
	//private collision colli_obj = new collision();
	// Use this for initialization
	void Start () {
		//level 1 - beginer
		InvokeRepeating("CreateBallClone", 3.0f, 1.1f);
	}
	
	// Update is called once per frame
	void CreateBallClone () {
		Ball = Instantiate (nBall, new Vector3 (0, 8, 0), transform.rotation) as GameObject;
		Ball.GetComponent<Renderer>().material = matList [Random.Range (0, matList.Length)];
		Ball.GetComponent<Rigidbody>().useGravity = true;
		//Ball.rigidbody.mass = 100;
		Ball.name = "Ball_";

		/// check level and move fordward

	}
}
