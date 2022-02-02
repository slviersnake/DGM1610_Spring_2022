using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscirpt : MonoBehaviour
{
    public float speed = 20.0f;
    
    public float turnSpeed = 50f;

    public float hInput;

    public float fInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");

       transform.Translate(Vector3.forward * Time.deltaTime * speed); 
       transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
