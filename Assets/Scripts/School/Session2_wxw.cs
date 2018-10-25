using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using RC3Student;

public class Session2_wxw : MonoBehaviour
{
    private int number1 = 10;

    private int number2 = 20;
    private int number3 = 30;
    private string[] names = {"Dave", "Tyson", "Jordi", "Octavian", "Panos"};



    private bool somebool = false;
    private string someName = "name";
    List<Student>Rc2018=new List<Student>();

	
	void Start () {

        Student wxw=new Student("1","2","3",4,"5");






        Debug.Log("A tutor is" + names[0]);
	    Debug.Log("A tutor is" + names[1]);
	    Debug.Log("A tutor is" + names[02]);

	    for (int i = 0; i <= names.Length-1; i++)
	    {
	        Debug.Log("A tutor is" + names[i]);
        }

	    foreach (var namesName in names)
	    {
	     Debug.Log(namesName);   
	    }
        if (number1<number2)
	    {
	        Debug.Log("number1 is smaller than number2");
	    }
	    else
	    {
	        Debug.Log("number2 is smaller than number1");
        }

	    if (number1<number2&&somebool==true)
	    {
	        Debug.Log("Answer to both qestion is yes!");

	    }

        if (number1<number2||somebool==true)
        {
            Debug.Log("Answer to both qestion is yes");

        }

	    if ((number1<number2&&somebool==true)&&(somebool==true&&someName=="name"))
	    {
	        Debug.Log("This is too confusing! Simply please.");
        }

	    Debug.Log("number1 smaller than number2");

	    number3 = (number1 < number2) ? 100 : 200;


	}
	
	
	void Update () {
		
	}
}
