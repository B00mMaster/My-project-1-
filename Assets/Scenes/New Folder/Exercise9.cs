using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise9 : MonoBehaviour
{
    public int candy = 00;
    public int people = 00;

    private int result;
     private void Start()
    {
        result = candy % people;
        Debug.Log($"{result} candies are left over");

        result = candy / people;
        Debug.Log($"{result} candies takes each person");

    }










}
