using UnityEngine;
using System.Collections;

public class FishMover : MonoBehaviour {
	public float speed = 1f;
	public float rightBoundaries = 10f;
	public float leftBoundaries = -10f;
	public bool isMovingRight = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
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
}
