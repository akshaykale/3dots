#pragma strict

function Start () {

}

function Update () {
	if(Input.GetButtonDown ("Fire1")){
		Rotate_tri();
	}
}

function Rotate_tri(){
	var oldRotation = transform.rotation;
	transform.Rotate(120,0,0);
	var newRotation = transform.rotation;
	
	for(var t = 0.0; t <=0.1f; t += Time.deltaTime){
		
		transform.rotation = Quaternion.Slerp(oldRotation, newRotation, t*20);
		yield;
	}
	
	transform.rotation = newRotation;
	
}