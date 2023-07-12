using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene(1);
    }

    public void ShopPressed()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
