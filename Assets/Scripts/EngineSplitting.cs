using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EngineSplitting : MonoBehaviour
{

    /*public Transform startMarker;*/
    public Transform endMarker;
    public float duration = 100f;
    private Vector3 initialPosition;
    public UnityEvent screwsRemoved;
    private bool localIsSplit = false;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        screwsRemoved.AddListener(startSplit);
        /*splitting();*/
    }

    // Update is called once per frame
    void startSplit()
    {
        Debug.Log("screw");
        splitting(false);
        localIsSplit = true;
    }
    public void splitting(bool isSplit)
    {
        if (!isSplit && !localIsSplit)
        {
            StartCoroutine(split(initialPosition, endMarker.position));
           
        }
        else if(localIsSplit)
        {
            StartCoroutine(split(endMarker.position, initialPosition));
            
        }

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



   

