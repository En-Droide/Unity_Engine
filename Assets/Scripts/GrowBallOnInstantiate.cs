using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowBallOnInstantiate : MonoBehaviour
{
    public float growTime;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector3.zero;
        StartCoroutine(Grow(growTime));
    }

    IEnumerator Grow(float time)
    {
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime / time;
            transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one, t);
            yield return null;
        }

    }
}
