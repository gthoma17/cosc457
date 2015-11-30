using UnityEngine;
using System.Collections;

public class HookController : MonoBehaviour {
	
	public float speed = 30;
	private Rigidbody rb;
	private bool enableHookAndLine = false;
	private string status = "";
	public float countdown = 5f;

	void Start ()
	{
		StartCoroutine( startTimer( countdown/2.5f ) );
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{
		if (enableHookAndLine) { //&& !screenOverlays.IsWon () && !screenOverlays.IsTriggered ()) {
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");
		
			Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		
			rb.AddForce (movement * speed);
		} 
	}

	private IEnumerator startTimer( float wait ) {
		status = "ready";
		yield return new WaitForSeconds(wait);
		status = "set";
		yield return new WaitForSeconds(wait);
		status = "fish";
		yield return new WaitForSeconds(wait/2);
		enableHookAndLine = true;
	}
	
	void OnGUI() {
		if (!enableHookAndLine) {
			if (status.Equals ("ready")) {
				GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nGet ready...");
			} else if (status.Equals ("set")) {
				GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nGet set...");
			} else if (status.Equals ("fish")) {
				GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nFISH!");
			}
		}
	}
}