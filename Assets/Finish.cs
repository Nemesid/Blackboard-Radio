using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

    public PlayerCollision PC;
    public BotCollision BC;
    public GameObject gameOverPannel;

    private void Update()
    {
        if(PC.isfinished == true && BC.isfinished == true)
        {
            gameOverPannel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
