using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameBool : MonoBehaviour
{
    public bool newGame;
    // Start is called before the first frame update
    public void Start()
    {
        newGame = true;
        SaveMangerDone.instance.DeleteSavedData();
    }
}
