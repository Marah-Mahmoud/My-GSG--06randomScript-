using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int n = 0;
        while (n < 20){
            int rand = Random.Range(1,21);
            Debug.Log(rand);
            n++;
            if (rand == 5)
            {
                //Debug.Log(rand);
                continue;
            }
            if (rand == 15)
            {
                //Debug.Log(rand);
                break;
            }
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
