using UnityEngine;
using System.Collections;

public class FishingLine : MonoBehaviour {
	public GameObject boat;

	// Use this for initialization
	void Start () {
		/*LineRenderer line = gameObject.AddComponent<LineRenderer>();
		line.SetColors(Color.black,Color.black);
		line.SetWidth(0.2f,0.2f);
		line.enabled = true;*/
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		LineRenderer line = GetComponent<LineRenderer>();
		line.SetPosition(0, this.transform.position);
		line.SetPosition(1, boat.transform.position);
	}
}
