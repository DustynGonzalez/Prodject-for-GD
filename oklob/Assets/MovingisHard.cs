using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class MovingisHard : MonoBehaviour
{    
    public float speedygonzales;

 
    void Start ()
    {
       
        speedygonzales = 4f;
    }

    void FixedUpdate()
    {
        
        transform.Translate
            (speedygonzales*Input.GetAxis("Horizontal")*Time.deltaTime,
            Input.GetAxis("Jump"),
            (speedygonzales*Input.GetAxis("Vertical")*Time.deltaTime));
    }
}
    
