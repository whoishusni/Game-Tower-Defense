using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    float timer = 0;
    public Text info;

    private void Start()
    {
        if (DataGame.isComplete)
        {
            info.text = "Selamat \n Kamu Menang!";
        }
        else
        {
            info.text = "Game Over \n Kamu Kalah!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (DataGame.isGameOver)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuUtama");
        }
    }

    public void retryGame()
    {
        SceneManager.LoadScene("GamePlay");
        DataGame.isGameOver = false;
        DataGame.isComplete = false;
    }
    public void quitGame()
    {
        SceneManager.LoadScene("MenuUtama");
    }
    public void exitGame()
    {
        Application.Quit();
    }
}
