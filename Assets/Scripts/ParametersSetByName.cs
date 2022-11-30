using System;
using UnityEngine;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public class ParametersSetByName : MonoBehaviour
{
    public FMOD.Studio.EventInstance Music;
    private WinUI win;

    public void Start()
    {
        Music = FMODUnity.RuntimeManager.CreateInstance("event:/Music");
        Music.start();
        win = gameObject.GetComponent<WinUI>();
    }

    private void Update()
    {
        
    }

    public void LevitatePiano(float track)
    {
        Music.setParameterByName("Piano", track);
     
    }

    public void RotateDrums(float track)
    {
        Music.setParameterByName("Drums", track);
       
    }

    public void UseGuitar(float track)
    {
        Music.setParameterByName("Guitar", track);
      
    }
    
   
}