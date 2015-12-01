using UnityEngine;
using System.Collections;

public class fishCollider : MonoBehaviour
{
	public Transform HookAndLineParent;
    public Transform CaughtFishHolder;
	public GameObject fishPrefab;
    public GameObject hookPrefab;
    public GameObject line;
    public Vector3 hookStartPos;
    public Vector3 lineStartPos;
    public Renderer rend;
    public GameObject hookedFish = null;


    //public void resetHook()
    //{
    //   line.transform.position = this.lineStartPos;
    //    this.transform.position = this.hookStartPos;
    //    Destroy(hookedFish);
    //    hookedFish = null;
    //}

    public void resetHook ()
    {
        this.line.transform.position = this.lineStartPos;
        this.transform.position = this.hookStartPos;
    }

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        hookStartPos = this.transform.position;
        lineStartPos = line.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("hook"))
        {
            return;
        }
        else if (other.tag.Equals("ceiling") && hookedFish != null)
        {
            screenOverlays.SetWon(true);
            Destroy(hookedFish);
            hookedFish = null;
        }
        else if ( other.tag.Equals("Fish"))
		{
            screenOverlays.addLife(-1);
            rend.enabled = true;
            line.transform.position = lineStartPos;
            this.transform.position = hookStartPos;
            Destroy(other.gameObject);
            Destroy(hookedFish);
        }
		else if(other.tag.Equals("Collectible") && hookedFish == null){
			Destroy(other.gameObject);
            GameObject fish = Instantiate(fishPrefab, this.gameObject.transform.position, this.gameObject.transform.rotation) as GameObject;
            fish.gameObject.tag = "hook";
            fish.transform.SetParent(HookAndLineParent);
            hookedFish = fish;
		}
        Debug.Log("hook collided with: " + other);
    }
    
}