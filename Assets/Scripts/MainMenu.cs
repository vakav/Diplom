using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public GameObject Menu;
   public GameObject SettingsMenu;

   public void Play()
   {
        SceneManager.LoadScene(1);
   }
   public void Settings()
   {
      Menu.SetActive(false);
      SettingsMenu.SetActive(true);
   }
   public void MenuSettings()
   {
      Menu.SetActive(true);
      SettingsMenu.SetActive(false);
   }
   
   public void Exit ()
   {
      Application.Quit();
   }


}
