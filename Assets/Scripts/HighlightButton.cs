using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightButton : MonoBehaviour
{
    public GameObject screw1Highlight;
    public GameObject screw2Highlight;
    public GameObject screw3Highlight;
    public GameObject screw4Highlight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ToggleHighlight()
    {
        screw1Highlight.SetActive(!screw1Highlight.activeSelf);
        screw2Highlight.SetActive(!screw2Highlight.activeSelf);
        screw3Highlight.SetActive(!screw3Highlight.activeSelf);
        screw4Highlight.SetActive(!screw4Highlight.activeSelf);
    }
}
