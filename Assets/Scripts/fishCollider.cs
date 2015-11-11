using UnityEngine;
using System.Collections;

public class fishCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        gameOverOverlay.setTrigger(true);
        Destroy(this.gameObject);

    }
    
}