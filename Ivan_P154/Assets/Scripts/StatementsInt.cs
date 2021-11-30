using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementsInt : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (score > 60)
       // {
       //     print("passed");
       // }

       // else
       // {
       //     print("try again");
       // }

        if (60 < score && score < 75)
        {
            print("passed well");
        }
        else if (75 < score && score < 100)
        {
            print("passed good");
        }
        else if (score == 100)
        {
            print("passed great");
        }
        else
        {
            print("try again");
        }

    }
}
