using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_player_1 : MonoBehaviour
{
    public Text scoreBoardPlayerOne;
    public int scorePlayerOne = 0;
    
    
    void Start()
    {
        scoreBoardPlayerOne.text = " " + scorePlayerOne;

    }


}


 