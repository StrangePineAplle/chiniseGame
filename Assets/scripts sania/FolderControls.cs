using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderControls : MonoBehaviour
{
    Item[] buttons;

    private void Start()
    {
        buttons = gameObject.GetComponentsInChildren<Item>();
    }

    public void deactivateObjects()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i].isBought == true) buttons[i].removeItem();
        }
    }
}
