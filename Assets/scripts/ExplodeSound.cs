using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeSound : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GetComponent<AudioSource>().Play ();
    }

   
}
