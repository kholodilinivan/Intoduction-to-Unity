using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformations : MonoBehaviour
{
    Vector3 newpos = new Vector3(0, 0.01f, 0);
    public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += newpos; // transform.position = transform.position + newpos;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += -transform.right*speed; // transform.position = transform.position + newpos;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed,0,0); 
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0, 0, speed);
            transform.localScale += newpos;
        }
    }
}
