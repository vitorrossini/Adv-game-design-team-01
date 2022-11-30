using UnityEngine;

public class LevelRotation : MonoBehaviour
{
    public float addValue;
    public float subtractValue;
    public float musicTrack;
    public ParametersSetByName music;
    public float rotationZ;
    public float speed = 1f;
    public bool play;
    private PlayerMovement movement;
   

    public void Start()
    {
        movement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        rotationZ = gameObject.transform.rotation.z;
        play = false;
    }
    
    public void Update()
    {
        TurnIt();
        PlayDrums();
    }

   
   public void TurnIt()
    {
        if (Input.GetButton("Rotate") && movement.GetComponent<PlayerMovement>().onTurnPlat == true)
        {
            play = true;
            Debug.LogError("yeah you can turn");


            
            rotationZ -= Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            rotationZ = Mathf.Clamp(rotationZ, -90, 90);

            transform.rotation = Quaternion.Euler(0, 0, rotationZ);


        }
        else
        {
            play = false;
        }
      

    }
   

   public void PlayDrums()

   {
       if (musicTrack <= 1f)
       {
           musicTrack = 1f;
       }
       if (musicTrack >= 2f)
       {
           musicTrack = 2f;
       }

       if (play)
       {
           musicTrack += subtractValue * Time.deltaTime;

       }

       else
       {
           musicTrack += addValue * Time.deltaTime;

       }
        
       music.RotateDrums(musicTrack);
   }



}
