using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Session3_wxw : MonoBehaviour
{
    public GameObject cubePrefab;
    public int spacing;
    public int GridX;
    public int GridY;
    public GameObject light;
    public GameObject objectReference;

    void Awake()
    {
    }

	void Start ()
	{
	    for (int i = 0; i < GridX; i++)
	    {
	        for (int j = 0; j < GridY; j++)
	        {
	            Instantiate(cubePrefab, new Vector3(i * spacing, j * spacing, 0), Quaternion.identity,this.transform);
	        }
	    }

        objectReference.transform.Translate(Vector3.up);
	}
	
	void Update ()
	{
	    Debug.Log("This computer can render a frame in: " + Time.deltaTime);	
        Debug.Log("since I started playing the game this amount of time has passed"+Time.timeSinceLevelLoad);
        Debug.Log("1"+Time.frameCount);
	    foreach (Transform child in this.transform)
	    {
	        
	        child.Translate(0,0, Random.Range(-0.1f,0.1f));
	    }

	    foreach (Transform child in this.transform)
	    {

	        child.RotateAroundLocal(Vector3.up, Random.value);
	    }
	    foreach (Transform child in this.transform)
	    {

	        child.localScale=new Vector3(Random.Range(1,1.5f), Random.Range(1, 1.5f), Random.Range(0.1f, 1.5f));
	    }

	    Vector3[] originalScal = new Vector3[this.transform.childCount];

	    for (int i = 0; i < transform.childCount; i++)
	    {
	        originalScal[i] = transform.GetChild(i).localScale;

	    }

	    if (Input.GetKeyDown(KeyCode.Space))
	    {
            
	        foreach (Transform child in this.transform)
	        {

	            child.localScale = child.localScale * 10f;
	        }
        }
	    else
	    {
	        for (int i = 0; i < transform.childCount; i++)
	        {
	            transform.GetChild(i).localScale = originalScal[i];

	        }
	    }

        if (Input.GetMouseButton(0))
        {
            light.GetComponent<Light>().color=new Color(Random.value, Random.value, Random.value);
        }

    }
}
