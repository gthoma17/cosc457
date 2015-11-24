using UnityEngine;
using System.Collections;

public class screenOverlays : MonoBehaviour
{

    static bool triggered = false;
    static bool won = false;

    void OnGUI()
    {
        if (triggered)
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "You were doing well...well, until you died...\n The game will restart in 3 seconds");
            StartCoroutine(restartGame());
        }
        if (won)
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "You were doing well...well, until you won...\n The game will restart in 3 seconds");
            StartCoroutine(restartGame());
        }
    }

    public static void SetTrigger(bool b)
    {
        triggered = b;
    }

	public static bool IsTriggered(){
		return triggered;
	}

	public static bool IsWon(){
		return won;
	}

    public static void SetWon(bool b)
    {
        won = b;
    }

    IEnumerator restartGame()
    {
        yield return new WaitForSeconds(5);
        triggered = false;
        won = false;
        Application.LoadLevel(Application.loadedLevel);
    }

}
