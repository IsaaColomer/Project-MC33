using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsCode : MonoBehaviour
{
   public GameObject musicGame;
   //public bool cock;
    // Start is called before the first frame update

   public void Play()
    {    
      SceneManager.LoadScene("Lvl1");
      SaveMangerDone.instance.Load();
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
