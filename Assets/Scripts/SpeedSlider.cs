using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedSlider : MonoBehaviour
{
    public Slider mySlider;
    public GameObject rotor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateSpeed()
    {
        rotor.GetComponent<EnginePower>().SetPower(mySlider.value);
    }
}
