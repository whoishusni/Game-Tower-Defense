using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public Slider slide;
    public Text coin;
    public Text time;
    float countdown = 90;
    float timer = 0;

    // Use this for initialization
    void Start()
    {
        DataGame.coin = 0;
        time.text = "02:00";
    }

    // Update is called once per frame
    void Update()
    {
        if (DataGame.coin < 30)
        {
            DataGame.coin += 7 * Time.deltaTime;
            slide.value = DataGame.coin;
            coin.text = DataGame.coin.ToString("000");
        }
        timer += Time.deltaTime;
        if (timer > 1f)
        {
            timer = 0;
            if (countdown > 0)
            {
                countdown--;
                string minutes = Mathf.Floor(countdown / 60).ToString("00");
                string seconds = Mathf.Floor(countdown % 60).ToString("00");
                time.text = minutes + ":" + seconds;
            }
            else
            {
                DataGame.isGameOver = true;
                DataGame.isComplete = false;
            }
        }
    }
}
