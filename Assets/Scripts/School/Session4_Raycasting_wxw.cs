using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_Raycasting_wxw : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {
        // Ray casting steps 
        // Step1 : Create ray
        Vector3 raycastingDirection = transform.forward;

        // Step 2 : See hat object is in front of me
        RaycastHit objectInFront;

        // Step 3 ; Do something with the object in front of me
        if (Physics.Raycast(transform.position, raycastingDirection, out objectInFront))
        {
            Debug.Log("Object in front is" + objectInFront.transform.name);
            objectInFront.transform.GetComponent<Listenscript>().seen = true;
        }
    }
}

