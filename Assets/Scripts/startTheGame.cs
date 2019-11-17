using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startTheGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartTheGame()
    {
        SceneManager.LoadScene(1);
    }
}
