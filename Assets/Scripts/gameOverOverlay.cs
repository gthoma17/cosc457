﻿using UnityEngine;
            StartCoroutine(restartGame());
        }

    IEnumerator restartGame()
    {
        yield return new WaitForSeconds(5);
        triggered = false;
        Application.LoadLevel(Application.loadedLevel);
    }