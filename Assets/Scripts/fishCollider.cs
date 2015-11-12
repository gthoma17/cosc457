using UnityEngine;
using System.Collections;

public class fishCollider : MonoBehaviour

{

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("ceiling"))
        {
            screenOverlays.setWon(true);
        }
        else if( other.tag.Equals("Fish"))
        {
            screenOverlays.setTrigger(true);
            Destroy(this.gameObject);
        }
        Debug.Log("collided");    
    }
    
}