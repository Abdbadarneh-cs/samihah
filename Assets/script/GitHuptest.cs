using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NumberGenerator : MonoBehaviour 
{
    public void Start() 
    {
        Random random = new Random();
        int number;

        while (true)
        {
            number = random.Next(1, 21); 
            if (number == 5)
            {
                continue; 
            }
            Debug.Log(number); 

            if (number == 15)
            {
                break; 
            }
        }
    }
}
