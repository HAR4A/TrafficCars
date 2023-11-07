using System.Collections;
using UnityEngine;

public class CarLights : MonoBehaviour
{
    
    public int showObject;
    void Start()
    {
        StartCoroutine(light());
        
    }

   IEnumerator light()
    {
        yield return new WaitForSeconds(0.2f);
        GameObject light = gameObject.transform.GetChild(showObject).gameObject;
        while (true)
        {
            light.SetActive(!light.activeSelf);
            yield return new WaitForSeconds(0.5f);
        }
    }


    
} 
