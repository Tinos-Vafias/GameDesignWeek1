using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_over : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    private float timer;
    public void GameOver()
    {
        timer = timer * 100;
        timer = MathF.Round(timer);
        Time.timeScale = 0;
        gameOverScreen.Setup(timer / 100);
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision");
        GameOver();
    }
}
