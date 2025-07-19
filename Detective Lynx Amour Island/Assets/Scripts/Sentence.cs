using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Sentence : MonoBehaviour
{
    public string word;

    public List <string> sentence = new List<string>();

    
    public List <string> rightAnswer = new List<string>();

    void Start()
    {

    }

    
    void Update()
    {
        if (sentence.Count == 3) 
        {
           checkSentence();
        }

    }

    public void checkSentence()
    {
        Debug.Log("trzy s³owa wybrane");

        //sprawdza czy listy s¹ takie same i na tej podstawie wygrana/przegrana
        if (sentence.SequenceEqual(rightAnswer))
        {
            Debug.Log("wygrana");
        }

        else
        {
            Debug.Log("fail");
        }
       
        sentence.Clear();
    }
}
