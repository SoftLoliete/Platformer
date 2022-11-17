using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuv2 : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenuUI;

    [SerializeField] private bool isPaused;

   private void update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }

        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
        Time.timeScale = 0f;
        PauseMenuUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1f;
        PauseMenuUI.SetActive(false);
        isPaused= false;
    }
}
