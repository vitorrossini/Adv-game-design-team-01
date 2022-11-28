using UnityEngine;

public class ParametersSetByName : MonoBehaviour
{
    public float speed = 10f;
    private FMOD.Studio.EventInstance Music;

    void Start()
    {
        Music = FMODUnity.RuntimeManager.CreateInstance("event:/Music");
        Music.start();
    }

    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            Music.setParameterByName("Piano", 1f * speed * Time.deltaTime);
        }
        if (Input.GetKeyUp("a"))
        {
            Music.setParameterByName("Piano", 2f * speed * Time.deltaTime);
        }
        
        if (Input.GetKeyDown("w"))
        {
            Music.setParameterByName("Bass", 1f);
        }
        if (Input.GetKeyUp("w"))
        {
            Music.setParameterByName("Bass", 2f);
        }
        
        if (Input.GetKeyDown("d"))
        {
            Music.setParameterByName("Drums", 1f);
        }
        if (Input.GetKeyUp("d"))
        {
            Music.setParameterByName("Drums", 2f);
        }
        
        if (Input.GetKeyDown("s"))
        {
            Music.setParameterByName("Guitar", 1f);
        }
        if (Input.GetKeyUp("s"))
        {
            Music.setParameterByName("Guitar", 2f);
        }
    }
}