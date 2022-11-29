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
        if (track <= 1f)
        {
            track = 1f;
        }
        if (track >= 2f)
        {
            track = 2f;
        }
    }

    public void RotateDrums(float track)
    {
        Music.setParameterByName("Drums", track);
        if (track <= 1f)
        {
            track = 1f;
        }
        if (track >= 2f)
        {
            track = 2f;
        }
    }

    public void UseGuitar(float track)
    {
        Music.setParameterByName("Guitar", track);
        if (track <= 1f)
        {
            track = 1f;
        }
        if (track >= 2f)
        {
            track = 2f;
        }
    }
    
   
}