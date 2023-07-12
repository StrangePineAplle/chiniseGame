using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIcontroller : MonoBehaviour
{
    public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
