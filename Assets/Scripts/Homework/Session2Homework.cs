using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Animalworld;
using Debug = UnityEngine.Debug;

public class Session2Homework : MonoBehaviour {


    private float Xweight = 101.0f;

    private float Yweight = 120.2f;
    private float Zweight = 300.0f;

    private string[] sleepingdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday","Saturday","Sunday" };



    private bool myBool = false;
   

    List<Animal> Animalworld = new List<Animal>();


    void Start()
    {

        Animal tiger= new Animal("Tiger", "male", 258.58f, 4, "Africa");
        Animal lion = new Animal("Lion", "Female", 221.8f, 4, "Africa");
        Animal panda = new Animal("Panda", "male", 158.5f, 4, "China");


        if (Xweight<Yweight)
        {
           Debug.Log("Mr X, you are heavier than Y! You need to lose weight!"); 
        }
        else
        {
            Debug.Log("Mr Y,you are heavier than X! ");
        }

        if (Xweight>Yweight&&Xweight>Yweight)
        {
            Debug.Log("Mr x,you are the heaviest tiger in the world!");
        }

        for (int i = 0; i <= sleepingdays.Length-1; i++)
        {
            Debug.Log("You can sleep on"+sleepingdays[i]);
        }

        foreach (string sleepingday in sleepingdays)
        {
            Debug.Log(sleepingday);
        }
    }


    void Update()
    {

    }
}