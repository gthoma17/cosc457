using UnityEngine;
using System.Collections;

public class BubbleSpawner : MonoBehaviour {

	public GameObject bubbleSprite;
	public float bubbleStartTime = 1f;
	public float secondsBetweenBubbleSpawn = .5f;

	GameObject bubble;
	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateBubbles",bubbleStartTime, secondsBetweenBubbleSpawn);
	}

	// Update is called once per frame
	void Update () {
	
	}

	void CreateBubbles(){
		bubble = Instantiate(bubbleSprite, new Vector3(Random.Range(-9,9),1,-18), Quaternion.identity) as GameObject;
		bubble.transform.Rotate(new Vector3(90,0,0));

	}
}
