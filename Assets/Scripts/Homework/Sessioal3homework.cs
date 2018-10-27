using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sessioal3homework : MonoBehaviour {

    public GameObject prefab;
    public float speed=1.0f;
    public Material color;

    void Start ()
    {
        Instantiate(prefab, this.transform);
       
       

    }
	
	
	void Update ()
	{
	    this.transform.Translate(Vector3.up *speed* Time.deltaTime);

	    if (Input.GetMouseButton(0))
	    {
	        color.color = new Color(Random.value, Random.value, Random.value);
	    }


    }
}
