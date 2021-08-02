using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Dropdown resolutionDrop;

    Resolution[] resolutions;

    void Start()
    {
       resolutions = Screen.resolutions;

       resolutionDrop.ClearOptions();

       List<string> options = new List<string>();

        int curr = 0;
       for(int i = 0; i < resolutions.Length; i++)
       {
           string option = resolutions[i].width + "x" + resolutions[i].height;
           options.Add(option);
           
           if(resolutions[i].width == Screen.currentResolution.width &&
           resolutions[i].height == Screen.currentResolution.height)
           {
               curr = i;
           }
       }

       resolutionDrop.AddOptions(options);
       resolutionDrop.value = curr;
       resolutionDrop.RefreshShownValue();
    }
    // Start is called before the first frame update
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetFullScreen (bool isFs)
    {
        Screen.fullScreen = isFs;
    }
}
