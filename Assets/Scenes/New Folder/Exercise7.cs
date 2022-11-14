using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    public string letter = "";

    private void Start()
    {
        if (letter is "a" or "e" or "i" or "o" or "u")

        { Debug.Log($"letter {letter} is a vowel"); }

        else { Debug.Log($"letter {letter} is a consonant"); }


    }





}
