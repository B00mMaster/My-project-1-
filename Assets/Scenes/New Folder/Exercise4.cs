using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    public int birthYear = 2003;

    public int currentYear = 2022;

    private void Start()
    {
        Debug.Log

   ($"If we are in the year {currentYear} and you were born in {birthYear}, you are {currentYear - birthYear} years old");
    }




}
