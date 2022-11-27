using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    [SerializeField] private AudioSource escSoundEffect;
    
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            escSoundEffect.Play();
            if(!pauseMenu.activeSelf)
            {
                Time.timeScale = 0f;
                pauseMenu.SetActive(true);
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1f;
                pauseMenu.SetActive(false);
                Cursor.visible = false;
            }
        }
    }
    public void quit()
    {
        Application.Quit();
    }
    public void resume()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        Cursor.visible = false;
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("mainmenu");
    }
}

//Followed tutorial for parts of this code using https://www.youtube.com/watch?v=nPigL-dIqgE&t=1949s&ab_channel=bblakeyyy