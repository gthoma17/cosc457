using UnityEngine;
using System.Collections;

public class FishMover : MonoBehaviour {
	public float speed = 1f;
	public float rightBoundaries = 10f;
	public float leftBoundaries = -10f;
	public bool isMovingLeft = false;
	// Use this for initialization
	void Start () {
		//rotates the sprites
		if(isMovingLeft)
		this.gameObject.transform.Rotate(new Vector3(0,180,0));
	}
	
	// Update is called once per frame
	void Update(){
		//makes the sprite move
		this.transform.position +=  (transform.right * Time.deltaTime) * speed;

		//destroys game objects when out of bounds
		if(isMovingLeft && this.transform.position.x < leftBoundaries)
			Destroy(this.gameObject);
		else if(!isMovingLeft && this.transform.position.x > rightBoundaries)
			Destroy (this.gameObject);
	}
}

/*
  void Update () {
		if(isMovingRight){
			this.transform.position +=  (transform.right * Time.deltaTime) * speed;
			if(this.transform.position.x > rightBoundaries)
				Destroy(this.gameObject);
		}
		else{
			this.transform.position -=  (transform.right * Time.deltaTime) * speed;
			if(this.transform.position.x < leftBoundaries)
				Destroy(this.gameObject);
		}
	}
 */
