using UnityEngine;
using System.Collections;

public class HookController : MonoBehaviour {
	
	public float speed;
	
	private Rigidbody rb;

	bool enableHookAndLine = false;

	int startingTimer = 300;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{
		if (enableHookAndLine) {
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");
		
			Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		
			rb.AddForce (movement * speed);
		} else {
			startingTimer--;

		    if(startingTimer == 0) {
				enableHookAndLine = true;
			}
		}
	}
}