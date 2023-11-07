
using UnityEngine;

public class ExhaustSound : MonoBehaviour
{
    public AudioClip[] clips;
    void Start()
    {
        if(PlayerPrefs.GetString("Music") != "no") {
            GetComponent<AudioSource>().clip = clips[Random.Range(0, clips.Length)];
        GetComponent<AudioSource>().Play ();
        }
    }

   
}
