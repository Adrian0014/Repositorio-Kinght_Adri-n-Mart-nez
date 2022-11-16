using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject title;
    public GameObject mainButtons;
    public GameObject optionsMenu;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

   
  
    public void OpenOptions()
    {
        title.SetActive(false);
        mainButtons.SetActive(true);
        optionsMenu.SetActive(true);
    }
}
