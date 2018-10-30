using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_Raycasting : MonoBehaviour {

	
	void Start ()
	{
		
	}
	
	
	void Update ()
	{

	    Vector3 castedRayDirection = transform.TransformDirection(Vector3.forward);
	        .
	    
	    RaycastHit objectInFront;

        if (Input.GetKey(KeyCode.W))
	    {
	        transform.Translate(Vector3.forward * 0.01f);
	    }
	    if (Input.GetKey(KeyCode.A))
	    {
	        transform.Translate(Vector3.left * 0.01f);
	    }
	    if (Input.GetKey(KeyCode.D))
	    {
	        transform.Translate(Vector3.right * 0.01f);
	    }
        // Move the cube down
        if (Input.GetKey(KeyCode.S))
	    {
	        transform.Translate(Vector3.back * 0.01f);
	    }
	    if (Physics.Raycast(transform.position, castedRayDirection, out objectInFront))
	    {
	        
	        Destroy(objectInFront.transform.gameObject);
	    }
    }
}
