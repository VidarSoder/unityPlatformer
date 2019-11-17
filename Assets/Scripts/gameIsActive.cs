using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameIsActive : MonoBehaviour
{
    // Start is called before the first frame update
    int lives = 3;

    private void Awake()
    {
        int amountOfGameSessions = FindObjectsOfType<gameIsActive>().Length;
        if(amountOfGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        
    }

    public void CheckIfPlayerDie()
    {
        if (lives > 1)
        {
            TakeLife();
        } else
        {
            ResetGame();
        }
    }

    private void TakeLife()
    {
        lives--;
        var activeScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activeScene);
    }

    private void ResetGame()
    {
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }

}
