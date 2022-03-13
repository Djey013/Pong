using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    
    public float speed = 0.01f;
    
    
   
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(transform.up * speed); 
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.up * speed);
        }

    }
    
    
        
}
