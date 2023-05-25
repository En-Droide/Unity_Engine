using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineSplitting : MonoBehaviour
{

    /*public Transform startMarker;*/
    public Transform endMarker;
    public float duration = 100f;
    private bool isSplit = false;
    private Vector3 initialPosition; 
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position; 
        /*splitting();*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            splitting();
        }
    }
    void splitting()
    {
        if (!isSplit)
        {
            StartCoroutine(split(initialPosition, endMarker.position));
           
        }
        else
        {
            StartCoroutine(split(endMarker.position, initialPosition));
            
        }
        isSplit = !isSplit;

    }
    IEnumerator split(Vector3 start, Vector3 end)
    {
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / duration);

            // Apply ease-in/out interpolation
            t = Mathf.SmoothStep(0f, 1f, t);

            transform.position = Vector3.Lerp(start, end, t);

            yield return null;
        }

        // Interpolation finished
    }

}



   

