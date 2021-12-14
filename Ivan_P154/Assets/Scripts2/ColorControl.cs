using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorControl : MonoBehaviour
{
    ScriptsControl script;
    // Start is called before the first frame update
    void Start()
    {
        // GetComponent<ScriptsControl>().score = 100;

        // GameObject.Find("Cylinder").GetComponent<ScriptsControl>().score = 90;

        script = GameObject.Find("Cylinder").GetComponent<ScriptsControl>();
        script.score = 85;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
