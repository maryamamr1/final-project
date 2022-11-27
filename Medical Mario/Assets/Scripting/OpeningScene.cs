using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningScene : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("level1");
    }

    public void EndGame()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
