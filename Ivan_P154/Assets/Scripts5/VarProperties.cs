using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarProperties : MonoBehaviour
{
    public int newScore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TotalScore totalscore = new TotalScore();
            totalscore.Score = newScore;
            print(totalscore.Score);
        }
    }
}
