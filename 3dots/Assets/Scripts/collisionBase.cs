using UnityEngine;
using System.Collections;

public class collisionBase : MonoBehaviour {

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Ball_")
		{
				Destroy(col.gameObject);
		}

	}
}
