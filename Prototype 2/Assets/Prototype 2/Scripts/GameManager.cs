using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void AddLives(int value)
    {
        lives += value;

        if (lives < 0)
        {
            Debug.Log("GAME OVER");
            lives = 0;
        }

        Debug.Log("����� = " + lives);
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("���� = " + score);
    }
}
