using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    public GameObject mycamera;
    public float speed = 20;
    public Vector3 horizontalAxis;
    public Vector3 verticalAxis;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Point the object at the world origin (0,0,0)
        mycamera.transform.LookAt(Vector3.zero);
        //Récupère les inputs de l'utilisateur (entre -1 et 1) sur les flèches directionnels (si elles sont bien configurées dans l'InputManager)
        float horizontalArrowsInput = Input.GetAxis("Horizontal");
        float verticalArrowsInput = Input.GetAxis("Vertical");
        //On obtient la vitesse de rotation en multipliant notre input (0 si aucun input) par la vitesse max puis on multiplie le tout par deltaTime pour être indépendant du framerate
        float resultingSpeed = speed * Time.deltaTime;

        //Pivote le transform selon l'axe donné par la vitesse obtenue.
        Vector3 rotateAxis = new Vector3(horizontalAxis.x * horizontalArrowsInput, horizontalAxis.y * horizontalArrowsInput, horizontalAxis.z * horizontalArrowsInput);
        transform.Rotate(rotateAxis * resultingSpeed);

        Vector3 translateAxis = new Vector3(verticalAxis.x * verticalArrowsInput, verticalAxis.y * verticalArrowsInput, verticalAxis.z * verticalArrowsInput);
        transform.Translate(translateAxis * resultingSpeed);
        
        if (transform.position.y > 2) transform.position = new Vector3(0, 2, 0);
        if (transform.position.y < -2) transform.position = new Vector3(0, -2, 0);

    }
}
