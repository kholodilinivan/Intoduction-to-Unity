using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    Transform camTransform;
    public float shakeTime;
    public float shakeRange;
    Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        camTransform = Camera.main.transform;
        originalPos = camTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCoroutine("ShakeCamera"); //        =     StartCoroutine(ShakeCamera());
        }
    }

    IEnumerator ShakeCamera()
    {
        float elapsedTime = 0;
        while(elapsedTime < shakeTime)
        {
            camTransform.position = Random.insideUnitSphere * shakeRange;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        camTransform.position = originalPos;
    }
}
