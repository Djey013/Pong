using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    
    public float speed = 0;
    public float speedup = 20;
    public Score_player_1 sc1;
    public Score_player_2 sc2;
    public int maxScore = 3;

    public Transform ballStart;

     
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        BallMovements();
        
        
    }
    
    private void BallMovements()    //mouvements de la balle
    {
        float x;
        float y;
        x = Random.Range(-1f, 1f);
        y = Random.Range(-1f, 1f);

        if (x < 0)
        {
            rb.AddForce(-transform.right * speed, ForceMode2D.Impulse); //a gauche
        }
        else
        {
            rb.AddForce(transform.right * speed, ForceMode2D.Impulse); //a droite
        }

        if (y < 0)
        {
            rb.AddForce(-transform.up * speedup, ForceMode2D.Impulse);    //en bas
          
        }
        else
        {
            rb.AddForce(transform.up * speedup, ForceMode2D.Impulse); //en haut
        }
       
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
  
        if (collision.gameObject.CompareTag("WallRight"))   // +1 au score du player 1
        {
            sc1.scorePlayerOne++;
            sc1.scoreBoardPlayerOne.text = " " + sc1.scorePlayerOne;
            this.gameObject.SetActive(false);
            Invoke("Reapparition", 3);


        }

        if (collision.gameObject.CompareTag("WallLeft"))    // +1 au score du player 2
        {
            sc2.scorePlayerTwo++;
            sc2.scoreBoardPlayerTwo.text = " " + sc2.scorePlayerTwo;
            this.gameObject.SetActive(false);
            Invoke("Reapparition", 3);

        }

        if (sc1.scorePlayerOne == maxScore || sc2.scorePlayerTwo == maxScore)   //Fin de partie si score = 3 (maxScore)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
            
        }
       
    }


    private void Reapparition()     // reapparition de la balle
    {
        this.gameObject.SetActive(true);
        transform.position = ballStart.transform.position;
        BallMovements();
    }

   

}

/*
     -----------------------------------------------------------------------------------------------

    
    //quit

    //random
        //Random BallStart = new Random();
    
    // public float restartDelay = 2f;        
            Invoke("GameOver", restartDelay);
    
    // players ne passe pas a travers les murs        

/*
-----------------------------------------------------------------------------------------------

   public float rotationSpeed = 0.5f;

   void Update()
   {
       transform.Rotate(Vector2.up * rotationSpeed, Space.World);
   }


 */