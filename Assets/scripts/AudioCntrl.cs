using System.Collections;
using UnityEngine;

public class AudioCntrl : MonoBehaviour
{
    public bool play;
    
    void Update()
    {
        if(PlayerPrefs.GetString("Music")!= "no" && !play){
            GetComponent<AudioSource>().Play();
            play = true;
        }
        else if (PlayerPrefs.GetString("Music") == "no" && play)
        {
            GetComponent<AudioSource>().Pause();
            play = false;
        }
    }
}
