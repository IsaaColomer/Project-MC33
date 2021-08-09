using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsCode : MonoBehaviour
{
   public GameObject musicGame;

   public void Play()
   {
      SceneManager.LoadScene("Lvl1");      
      Debug.Log("Reaches Scene Loader");
   }
   public void Options()
   {
      SceneManager.LoadScene("Options");
   }
   public void Quit()
   {
      Application.Quit();
   }

   public void Title()
   {
      SceneManager.LoadScene("StartMenu");
   }
      public void Opt()
   {
      SceneManager.LoadScene("Opt");
   }
   public void LoadGame()
   {
      SceneManager.LoadScene("Lvl1");
   }
   public void BackToGame()
   {
      SceneManager.LoadScene("Lvl1");
   }
}
