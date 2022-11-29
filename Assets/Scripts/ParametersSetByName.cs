using UnityEngine;

public class ParametersSetByName : MonoBehaviour
{
    public FMOD.Studio.EventInstance Music;

    public void Start()
    {
        Music = FMODUnity.RuntimeManager.CreateInstance("event:/Music");
        Music.start();
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