using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsCode : MonoBehaviour
{
   public GameObject musicGame;

   public void Play()
   {
      SaveMangerDone.instance.DeleteSavedData();
      Debug.Log("Reaches the Delete Saved Data!");
           
      SaveMangerDone.instance.NewGameSavedData();
      Debug.Log("Reaches the NewGameSavedData!");

      SaveMangerDone.instance.Load();
      Debug.Log("Reaches the Load!");

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
}
