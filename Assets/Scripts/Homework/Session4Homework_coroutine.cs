using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;


public class Session4Homework_coroutine : MonoBehaviour
{

    public GameObject prefabCube;

	// Use this for initialization
	void Start ()
	{
	    

        StartCoroutine(ChangeColors());


	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator ChangeColors()
    {
        yield return new WaitForSeconds(0.5f);
        prefabCube.GetComponent<MeshRenderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.5f);
        prefabCube.GetComponent<MeshRenderer>().material.color = Color.yellow;
        yield return new WaitForSeconds(0.5f);
        prefabCube.GetComponent<MeshRenderer>().material.color = Color.green;
        yield return new WaitForSeconds(0.5f);
        prefabCube.GetComponent<MeshRenderer>().material.color = Color.white;
        yield return new WaitForSeconds(0.5f);
        prefabCube.GetComponent<MeshRenderer>().material.color = Color.magenta;
        yield return StartCoroutine(ChangeColors());


    }





}
