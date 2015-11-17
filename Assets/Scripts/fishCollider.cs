using UnityEngine;
using System.Collections;

public class fishCollider : MonoBehaviour
{
	public Transform HookAndLineParent;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("ceiling"))
        {
            screenOverlays.SetWon(true);
        }
        else if( other.tag.Equals("Fish"))
        {
            screenOverlays.SetTrigger(true);
            Destroy(this.gameObject);
        }
		else if(other.tag.Equals("Collectible")){
			other.transform.SetParent(HookAndLineParent);
		}
        Debug.Log("collided");    
    }
    
}