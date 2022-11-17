using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool isPaused = false;

    public void pauseGame()
    {

        {
            Time.timeScale = 0f;
            isPaused = true;

        }
    }

}
