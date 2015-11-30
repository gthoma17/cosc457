using UnityEngine;
using System.Collections;

public class enemyCollider : MonoBehaviour
{
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }


    void OnTriggerEnter(Collider other)
	{
        if (other.tag.Equals("hook"))
        {
            return;
        }
        if (other.tag.Equals("ceiling"))
        {
            screenOverlays.SetWon(true);
        }
        
        Debug.Log("fish collided with: " + other);
    }
}
