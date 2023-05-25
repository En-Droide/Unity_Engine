using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeThrough : MonoBehaviour
{
    public GameObject SeeThroughSphere;
    bool isSphereInstantiated = false;
    GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.transform != null)
                {
                    if (raycastHit.transform.gameObject.name == "EngineBack")
                    {
                        if (isSphereInstantiated)
                        {
                            Destroy(sphere);
                        }
                        else
                        {
                            isSphereInstantiated = true;
                        }
                        sphere = Instantiate(SeeThroughSphere, raycastHit.point, Quaternion.identity);
                    }
                    else
                    {
                        //Debug.Log(raycastHit.transform.gameObject.name);
                    }
                }
            }
        }

    }
    
}
