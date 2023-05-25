using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnsplitButton : MonoBehaviour
{
    public GameObject rotor;
    public GameObject back;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Unsplit()
    {
        rotor.GetComponent<EngineSplitting>().splitting(true);
        back.GetComponent<EngineSplitting>().splitting(true);
    }
}
