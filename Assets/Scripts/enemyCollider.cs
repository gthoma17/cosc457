using UnityEngine;
using System.Collections;

public class enemyCollider : MonoBehaviour {


	void OnTriggerEnter(Collider enemy)
	{
		if (enemy.tag.Equals("ceiling"))
		{
			screenOverlays.SetWon(true);
		}
		else if( enemy.tag.Equals("Fish"))
		{
			screenOverlays.SetTrigger(true);
			Destroy(this.gameObject);
		}
		Debug.Log("collided");
	}
}
