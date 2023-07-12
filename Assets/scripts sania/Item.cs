using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public int cost;
    public bool isBought = false, isEquipped = false;

    Image button;
    ShopControls shop;
    FolderControls folder;

    public GameObject manilov;
    
    private void Start()
    {
        button = gameObject.GetComponent<Image>();
        shop = gameObject.GetComponentInParent<ShopControls>();
        folder = gameObject.GetComponentInParent<FolderControls>();
    }

    public void buyItem()
    {
        button.color = Color.yellow;
        shop.addItem(cost);
        isBought = true;
    }

    public void equipItem()
    {
        folder.deactivateObjects();
        button.color = Color.green;
        manilov.SetActive(true);
        isEquipped = true;
    }

    public void removeItem()
    {
        button.color = Color.yellow;
        manilov.SetActive(false);
        isEquipped = false;
    }

    public void pressItemButton()
    {
        if (isBought == false && isEquipped == false) {
            buyItem();
        } else if (isBought == true && isEquipped == false) {
            equipItem();
        } else if (isBought == true && isEquipped == true) {
            removeItem();
        }
    }
}
