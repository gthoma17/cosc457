using UnityEngine;
using System.Collections;

public class BubbleMover : MonoBehaviour {
	public float speed = 1f;
	public float boundaries = -1f;
	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position +=  (transform.up * Time.deltaTime) * speed;
		
		if(this.transform.position.z > boundaries)
			Destroy(this.gameObject);
	}
}
