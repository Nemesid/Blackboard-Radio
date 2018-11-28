using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreBoard : MonoBehaviour {

    public Text Wins;
    public PlayerCollision PC;
    public BotCollision BC;
    public GameObject gameOverPannel;
    private void Update()
    {
        if(gameOverPannel)
        {
            if(PC.timeCount > BC.timeCount)
            {
                Wins.text = "<b>Bot</b> Wins";
            }

            if (PC.timeCount < BC.timeCount)
            {
                Wins.text = "<b>Player</b> Wins";
            }
        }

    }
}
