 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 
 public class Timer : MonoBehaviour 
 {
     public Text timerLabel;
 
     private float time;
     private float minutes;
     private float seconds;

     public void Start()
     {
        SaveMangerDone.instance.Load();
        time = SaveMangerDone.instance.activeSave.time;
        
     }
 
     void Update()
     {
        SaveMangerDone.instance.activeSave.time = time;
        
        time += Time.deltaTime;
 
        minutes = time / 60; //Divide the guiTime by sixty to get the minutes.
        seconds = time % 60;//Use the euclidean division for the seconds.
        
         //update the label value
        timerLabel.text = string.Format ("{0:00} : {1:00} ", minutes, seconds);
     }
 }