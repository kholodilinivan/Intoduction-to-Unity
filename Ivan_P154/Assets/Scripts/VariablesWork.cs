using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariablesWork : MonoBehaviour
{
    public int number = 5;
    float position = 5.1f;
    char letter = 'a';
    public string name;


    // Start is called before the first frame update
    void Start()
    {
        print(number);
        print("position: " + position);
        print("letter: " + letter);
    }

    // Update is called once per frame
    void Update()
    {
        print("MyName is " + name);
    }
}
