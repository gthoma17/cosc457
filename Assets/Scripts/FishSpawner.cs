using UnityEngine;
using System.Collections;

public class FishSpawner : MonoBehaviour {

	//public float posX = 0f;
	//public float posY = 0f;
	public GameObject fishPrefab;
	public float fishStartingTime = 1f;
	public float secondsBetweenFishSpawn = 1f;

	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateFish",fishStartingTime,secondsBetweenFishSpawn );
	}
	
	// Update is called once per frame
	void Update () {
	}

	void CreateFish(){
		GameObject fish = Instantiate(fishPrefab) as GameObject;
		fish.transform.position = transform.position;
	}
		
}
