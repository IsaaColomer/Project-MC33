using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsCode : MonoBehaviour
{
    // Start is called before the first frame update
   public void Play()
   {
       SceneManager.LoadScene("Lvl1");
   }
   public void Quit()
   {
       Debug.Log("Quit");
       Application.Quit();
   }
}
