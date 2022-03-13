using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    public int lancer;
    public int lancer1;
    public int lancer2;
   
    
    void Start()
    {
        DiceOne();
        DiceTwo();
        ScoreLancer();

    }

    private void DiceOne()
    {
        lancer1 = Random.Range(1, 6);
        Debug.Log("Premier Dé : " + lancer1);
        
    }
   
    private void DiceTwo()
    {
        lancer2 = Random.Range(1, 6);
        Debug.Log("Deuxième Dé : " + lancer2);
    }

    private void ScoreLancer()
    {
        lancer = lancer1 + lancer2;     //autre possibilité : lancer 1 = lancer1 + lancer2 >> l'affectation n'impactera pas le resultat du lancer 1 car appliqué après (seulement lors de l'affectation/addition)
        Debug.Log(lancer);
    }
   
    
}
