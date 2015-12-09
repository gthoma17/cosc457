using UnityEngine;
using System.Collections;

public class ButtonBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("escape")){
			if(Application.loadedLevelName.Equals("MainMenu")){
				Debug.Log("I Quit The Game");
				Application.Quit();
			}
			else{
				Debug.Log("I went back to the main menu");
				Application.LoadLevel("MainMenu");
			}
		}
	}

	public void StartNextLevel(string levelName){
		Application.LoadLevel(levelName);
		screenOverlays.setLife(3);
	}

	public void ExitGame(){
		//quit will not work in the editor. 
		Debug.Log("I quit");
		Application.Quit();
	}

	public void HowTo(string levelName){
		Application.LoadLevel(levelName);
	}
}
