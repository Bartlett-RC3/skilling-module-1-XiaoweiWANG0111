using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Session1Homework : MonoBehaviour
{

    public string Name = "WXW";
	public int Age = 24;
    public float Height = 187.6f;
    public double Weight= Double.MaxValue;
    private string[] Workingdays=new string[7]{"Monaday","Tuesday","Wednesday","Thursday","Friday","Saturday","sunday"};
    private bool Truth = true;

    List<int> favouriteNumbers = new List<int>();
    

    Dictionary<string, string> Hobbies = new Dictionary<string, string>();

    void Start ()
    {

        Debug.Log("Hi,Your name is"+Name+". Your age is"+Age+". Your height is"+Height+". Your weight is"+Weight+". You have to work for"+Workingdays.Length+"days"+". It is"+Truth+". Good lucky!");

        favouriteNumbers.Add(1);    
        favouriteNumbers.Add(6);
        favouriteNumbers.Add(7);
        favouriteNumbers.Add(8);

        Debug.Log("My favourite number is"+favouriteNumbers[3]);

        favouriteNumbers.Clear();

       
        
        Hobbies.Add("outside", "swimming");
        Hobbies.Add("inside", "reading");
        

        if (Hobbies.ContainsKey("outside"))
        {
            Debug.Log("My hobby is" + Hobbies.Values);
        }



    }


    void Update ()
	{
		
	}
}
