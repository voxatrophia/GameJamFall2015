using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager i;

    void Awake()
    {
        if (i == null)
        {
            i = this;
        }
        else {
            Destroy(this);
        }
    }

    public void RestartGame()
    {
        Application.LoadLevel(1);
    }

    public void ResetGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void NextLevel() {
        Application.LoadLevel(Application.loadedLevel + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
