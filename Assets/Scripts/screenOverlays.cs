﻿using UnityEngine;
using System.Collections;

public class screenOverlays : MonoBehaviour
{

    static bool lost = false;
    static bool won = false;
    public GUISkin mySkin = null;
    static string score = "0";
    static string lives = "3";
    public GameObject hook;
	bool isDeactivated = false;

    void OnGUI()
    {
        GUI.skin = mySkin;
        GUI.Label(new Rect(0, 0, 100, 100), "Score:\n" + score, "box");
        GUI.Label(new Rect(Screen.width-100, 0, 100, 100), "Lives:\n" + lives, "box");
        if (lost)
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "You were doing well...well, until you died...", "label");
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "\n\n The game will restart in 3 seconds", "box");
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "\n\n\n\n\n\n\n\n Your final score was "+score+"\n\nThat's the highest score we've had today!\n\nNow give someone else a chance!", "box");
            StartCoroutine(restartGame());
        }

        if (won)
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "GOOD JOB","label");
			if(!isDeactivated)
            	addScore(827);
            StartCoroutine(restartGame());
        }
    }

    public static void SetLost(bool b)
    {
        lost = b;
    }

	public static bool IsLost(){
		return lost;
	}

	public static bool IsWon(){
		return won;
	}

    public static void SetWon(bool b)
    {
        won = b;
    }
    public static void addScore(int a)
    {
        int tempScore = int.Parse(score);
        tempScore = tempScore + a;
        score = tempScore.ToString();
    }
    public static void addLife(int a)
    {
        int tempLives = int.Parse(lives);
        tempLives = tempLives + a;
        if (tempLives <= 0)
        {
            lost = true;
        }
        lives = tempLives.ToString();
    }

	public static void setLife(int a){
		lives = a.ToString();
	}


    IEnumerator restartGame()
    {
        if (won)
        {
            hook = GameObject.Find("Hook");
            hook.SendMessage("resetHook");
			isDeactivated = true;
            yield return new WaitForSeconds(3);
            won = false;
			isDeactivated = false;
        }
        else if (lost)
        {
            yield return new WaitForSeconds(5);
            score = "0";
            lives = "3";
            lost = false;
            Application.LoadLevel(Application.loadedLevel);
        }      
    }

}
