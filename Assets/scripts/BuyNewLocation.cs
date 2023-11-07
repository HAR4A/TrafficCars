using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BuyNewLocation : MonoBehaviour
{
    public GameObject checkedButton;
    public Sprite uncheckedButton, checkedButtonSprite;
    public GameObject[] notCurrentLocationButtons;
    public GameObject[] buttonsToDisable;
    [SerializeField]
    private Text coins;
    [SerializeField]
    private int price;
    [SerializeField]
    private string nameOfLocation;


    void Awake()
    {
        if (PlayerPrefs.GetString(nameOfLocation) == "Open")
        {
            for (int i = 0; i < buttonsToDisable.Length; i++)
                buttonsToDisable[i].SetActive(false);
            checkedButton.SetActive(true);
        }

    }


    void OnMouseUpAsButton() 
    {
        if (PlayerPrefs.GetInt ("Coins") >= price)
        {
            PlayerPrefs.SetString("Location", nameOfLocation);
            PlayerPrefs.SetString(nameOfLocation, "Open");
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - price);
            coins.text = PlayerPrefs.GetInt("Coins").ToString();
            for (int i = 0; i < buttonsToDisable.Length; i++)
                buttonsToDisable[i].SetActive(false);


            for (int i = 0; i < notCurrentLocationButtons.Length; i++)
                notCurrentLocationButtons[i].GetComponent<Image>().sprite = uncheckedButton;
            checkedButton.SetActive(true );
            checkedButton.transform.GetChild(0).GetComponent<Image>().sprite = checkedButtonSprite;
        }
    }
}
