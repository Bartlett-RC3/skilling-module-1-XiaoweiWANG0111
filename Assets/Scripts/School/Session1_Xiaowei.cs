using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Session1_Xiaowei : MonoBehaviour
{

    //Numbers
    int myInterger = 0111;
    int largestInteger = int.MaxValue;
    int smallestInteger = int.MinValue;

    double myDouble = 54.3;
    double maxDouble = double.MaxValue;

    float myFloat = 32.456f;

    //text
    string myString = "This is the new awesome RC3! Better than ever";
    private bool myBoolean = true;
    private bool falseBoolean = false;

    //Array
    private int[] myIntArray =
    {
        1, 2, 3, 4, 5, 6, 7
    };
    int[] tewntyElementsArray=new int[20];
    private int[,] xyArray = new int[4, 5];

    private double[] doubleArray = {10.4, 12.2, 49, 72.9};
    
    //List
    List<int> myList=new List<int>();

    Dictionary<string,string>movingAnimals=new Dictionary<string, string>();


	
	void Start ()
	{
	    myIntArray[2] = 300;

        Debug.Log(myIntArray[2].ToString());

        myList.Add(4321);
        myList.Add(41);
	    myList.Add(1);


	    Debug.Log(myList[2].ToString());
        Debug.Log(myList[myList.Count-1]);

        myList.Clear();

	    movingAnimals.Add("flying","eagle");
        movingAnimals.Add("flying","parrot");
	    movingAnimals.Add("walking", "human");
	    movingAnimals.Add("walking", "dog");

	    if (movingAnimals.ContainsKey("flying"))
	    {
	        Debug.Log("A flying animal is"+ movingAnimals.Values);
	    }



    }


    void Update ()
    {

        myFloat = 13.4f;


    }

    float Numberaddition(float a, float b)
    {
        return a + b;
    }

    void PrintSomeNumbers()
    {
        Debug.Log(myList[0]);
        Debug.Log(myInterger);
    }
}
