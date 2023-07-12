using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControls : MonoBehaviour
{
    public int money;
    public Text moneyText;
    public Button skinsBtn, itemsBtn;
    public GameObject skinsFld, itemsFld;

    void Start()
    {
        moneyText.text = money.ToString();
    }

    public void addItem(int cost_)
    {
        money -= cost_;
        moneyText.text = money.ToString();
    }

    public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void switchToItems()
    {
        itemsBtn.interactable = false;
        skinsBtn.interactable = true;
        skinsFld.SetActive(false);
        itemsFld.SetActive(true);
    }

    public void switchToSkins()
    {
        itemsBtn.interactable = true;
        skinsBtn.interactable = false;
        skinsFld.SetActive(true);
        itemsFld.SetActive(false);
    }
}
