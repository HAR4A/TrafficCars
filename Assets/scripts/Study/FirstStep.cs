using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(MoveCar))]
public class FirstStep : MonoBehaviour
{
    public GameObject secondCar, exhaust;
    public Text study;
    private bool firstStep;

    void Start()
    {
        GetComponent<MoveCar>().speed = 0f;
        Invoke("MoveCar", 1f);
    }

    
    void Update()
    {
        if (transform.position.x < 16f && !firstStep)
        {
            firstStep = true;
            GetComponent<MoveCar>().speed = 2f;
            study.text = "Нажмите на машинку чтобы ее ускорить";
        }
    }

    void MoveCar()
    {
        GetComponent<MoveCar>().speed = 12f;
    }

    private void OnMouseDown()
    {
        if (firstStep)
        {
            GetComponent<MoveCar>().speed = 30f;
            study.text = "";
            GameObject ex = Instantiate(exhaust,
                new Vector3(gameObject.transform.position.x, 0.2f, gameObject.transform.position.z), Quaternion.Euler(new Vector3(90, 0, 0))) as GameObject;
            Destroy(ex, 1f);
        }
    }

    void OnDisable()
    {
        secondCar.SetActive(true);
    }
}
