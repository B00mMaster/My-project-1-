using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise6 : MonoBehaviour
{
    public int allWeek = 00;

    private void Start()
    {
        if(allWeek>5) { Debug.Log($"Day {allWeek} belong to the weekend"); }

        else { Debug.Log($"Day {allWeek} does not belong to the weekend"); }




    }
}
