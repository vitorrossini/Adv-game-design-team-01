using UnityEngine;

public class ParametersSetByName : MonoBehaviour
{
    public float speed = 10f;
    public  FMOD.Studio.EventInstance Music;

   public  void Start()
    {
        Music = FMODUnity.RuntimeManager.CreateInstance("event:/Music");
        Music.start();
    }

    public void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            
        }
        if (Input.GetKeyUp("a"))
        {
            
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

    public void RotatePiano1()
    {
        Music.setParameterByName("Piano", 1f);

        /* if (something)
         * {
         * Music.setParameterByName("Piano", 2f);
         * }*/

    }
    public void RotatePiano2()
    {
        
          Music.setParameterByName("Piano", 2f);
         
    }
}