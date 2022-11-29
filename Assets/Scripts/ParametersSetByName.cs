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

    public void LevitatePiano2()
    {
        Music.setParameterByName("Piano", 2f);
    }

    public void RotateDrums1()
    {
        Music.setParameterByName("Drums", 1f);
    }

    public void RotateDrums2()
    {
        Music.setParameterByName("Drums", 2f);
    }

    public void UseGuitar0()
    {

    }
    
    public void UseGuitar1()
    {
        Music.setParameterByName("Guitar", 1f);
    }

    public void UseGuitar2()
    {
        Music.setParameterByName("Guitar", 2f);
    }
}