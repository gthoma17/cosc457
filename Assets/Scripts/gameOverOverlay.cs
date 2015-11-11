using UnityEngine;using System.Collections;public class gameOverOverlay : MonoBehaviour{    static bool triggered = false;    void OnGUI()    {        if (triggered)        {                        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "You were doing well until you died...\n The game will restart in 3 seconds");
            StartCoroutine(restartGame());
        }    }    public static void setTrigger(bool b)    {        triggered = b;    }

    IEnumerator restartGame()
    {
        yield return new WaitForSeconds(5);
        triggered = false;
        Application.LoadLevel(Application.loadedLevel);
    }}