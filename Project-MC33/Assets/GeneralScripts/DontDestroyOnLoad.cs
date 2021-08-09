using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    static DontDestroyOnLoad instance = null;
    // Start is called before the first frame update
 void Awake () {
      if (instance != null)
         Destroy (gameObject);
      else {
         instance = this;
         GameObject.DontDestroyOnLoad(gameObject);
      }
   }
}
