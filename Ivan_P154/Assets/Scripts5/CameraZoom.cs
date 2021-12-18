using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoomSpeed2d = 20f;
    public float zoomSpeed3d = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.orthographic)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0) // zoom in
            {
                Camera.main.orthographicSize -= zoomSpeed2d * Time.deltaTime;
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0) // zoom out
            {
                Camera.main.orthographicSize += zoomSpeed2d * Time.deltaTime;
            }
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, 1, 5); // restricts within [1;5]
        }
        else
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0) // zoom in
            {
                Camera.main.fieldOfView -= zoomSpeed3d * Time.deltaTime;
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0) // zoom out
            {
                Camera.main.fieldOfView += zoomSpeed3d * Time.deltaTime;
            }
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 10, 60); // restricts within [1;5]
        }
    }
}
