using UnityEngine;
using System.Collections;

public class fishCollider : MonoBehaviour
{
	public Transform HookAndLineParent;
	FishMover fm = new FishMover();

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("ceiling"))
        {
            screenOverlays.SetWon(true);
        }
        /*else if( other.tag.Equals("Fish"))
        {
            screenOverlays.SetTrigger(true);
            Destroy(this.gameObject);
        }
        */
		else if(other.tag.Equals("Collectible")){
			other.transform.SetParent(HookAndLineParent);
			fm.speed = 0;
		}
        Debug.Log("collided");    
    }
    
}