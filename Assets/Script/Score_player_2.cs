using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_player_2 : MonoBehaviour
{
    public Text scoreBoardPlayerTwo;
    public int scorePlayerTwo = 0;


    void Start()
    {
        scoreBoardPlayerTwo.text = " " + scorePlayerTwo;
    }

    
}
