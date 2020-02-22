using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyed : MonoBehaviour
{
    public bool isPlayer = true;
    private void OnDestroy()
    {
        if (!DataGame.isGameOver)
            if (isPlayer)
            {
                DataGame.isGameOver = true;
                DataGame.isComplete = false;
                Debug.Log("Player Lost");
            }
            else
            {
                DataGame.isGameOver = true;
                DataGame.isComplete = true;
                Debug.Log("Player Win");
            }
    }
}
