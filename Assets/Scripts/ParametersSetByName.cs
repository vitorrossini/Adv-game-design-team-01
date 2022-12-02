using System;
using UnityEngine;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public class ParametersSetByName : MonoBehaviour
{
    public FMOD.Studio.EventInstance Music;
    private PauseMenu retry;
    private Goal goal;

    public void Start()
    {
       Music = FMODUnity.RuntimeManager.CreateInstance("event:/Music");
       Music.start();
        retry = GameObject.Find("Menu").GetComponent<PauseMenu>();
        goal = GameObject.Find("FinalButton").GetComponent<Goal>();
    }

    private void Update()
    {
        if (goal.win || retry.retried)

        {
            Debug.LogWarning("should work");
            Music.release();
            Music.stop(STOP_MODE.IMMEDIATE);
        }
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