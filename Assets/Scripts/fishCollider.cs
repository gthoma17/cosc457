using UnityEngine;
using System.Collections;

public class fishCollider : MonoBehaviour

{

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("collided");
        gameOverOverlay.setTrigger(true);
        Destroy(this.gameObject);
    }
    
}