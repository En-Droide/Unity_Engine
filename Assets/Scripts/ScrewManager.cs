using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewManager : MonoBehaviour
{

    public GameObject screw1;
    public GameObject screw2;
    public GameObject screw3;
    public GameObject screw4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.transform != null)
                {
                    if (raycastHit.transform.gameObject.name == "Screw1" || raycastHit.transform.gameObject.name == "Screw2" || raycastHit.transform.gameObject.name == "Screw3" || raycastHit.transform.gameObject.name == "Screw4")
                    {
                        raycastHit.transform.gameObject.SetActive(false);
                    }
                    if (screw1.activeSelf == false  && screw2.activeSelf == false && screw3.activeSelf == false && screw4.activeSelf == false)
                    {
                        Debug.Log("true");

                       
}
                }
            }
        }
    }
}
