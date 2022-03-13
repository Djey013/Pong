using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectApparition : MonoBehaviour
{
    public GameObject objectApparition1;
    public GameObject objectPosition;


    public void Start()
    {
        Invoke("Apparition", 3);
    }

    public void Apparition()
    {
        Instantiate<GameObject>(objectApparition1, objectPosition.transform);
    }
}
