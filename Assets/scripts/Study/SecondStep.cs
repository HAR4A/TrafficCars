using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondStep : MonoBehaviour
{
    public Text study;



    void Start()
    {
        study.text = "ÑËÅÄÈÒÅ ÊÓÄÀ ÏÎÂÎĞÀ×ÈÂÀÅÒ ÌÀØÈÍÊÀ";
    }


    void OnDisable()
    {
        PlayerPrefs.SetString("study" ,"Done");
        SceneManager.LoadScene("game");
    }

}
