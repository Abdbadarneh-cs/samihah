using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnySentenceGenerator : MonoBehaviour 
{
    void Start() 
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        Random random = new Random();
        string sentence = "";
        int count = 0;

        while (count < 7)
        {
            string word = words[random.Next(words.Length)];
            sentence += word + " ";
            count++;
        }

        Debug.Log(sentence); 
    }
}
