using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed = 0.01f;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.up * speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-transform.up * speed);
        }

    }
}
