using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentenceGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] words = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish","Tree", "Monkey", "Ball", "Bird"};
        //string[] words = new string[10] {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish","Tree", "Monkey", "Ball", "Bird"};
        string sentence = " ";
        int wordCount = 0;
        while (wordCount < 7)
        {
            int rand = Random.Range(0,words.Length);
            if (wordCount == 0)
            {
                sentence += words[rand] + " ";
            }
            sentence +="EL" + words[rand] + " ";
            wordCount++;
        }
        Debug.Log("Funny sentence:" + sentence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
