using UnityEngine;
using System.Collections;

public class fishCollider : MonoBehaviour
{
	public Transform HookAndLineParent;
	public GameObject fishPrefab;

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
			Destroy(other.gameObject);
			GameObject fish = Instantiate(fishPrefab, this.gameObject.transform.position, this.gameObject.transform.rotation) as GameObject;
			fish.AddComponent <enemyCollider>();
			Destroy(this.gameObject);
			fish.transform.SetParent(HookAndLineParent);
			//Destroy(other.GetComponent("FishMover"));

		}
		Debug.Log("collided");    
	}
    
}