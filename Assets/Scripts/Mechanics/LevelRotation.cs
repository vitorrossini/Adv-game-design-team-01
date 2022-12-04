using UnityEngine;

public class LevelRotation : MonoBehaviour
{
    // Script that allows player to rotate the level (or whatever it is a child of the game object this script holds). It has a limit to rotate only 90 degrees left or right.


    public float addValue;
    public float subtractValue;
    public float musicTrack;
    public ParametersSetByName music;
    public float rotationZ;
    public float speed = 1f;
    public bool play;
    public bool canMovePlatforms;
    private PlayerMovement movement;
    private Animator animator;
   

    public void Start()
    {
        movement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        animator = GameObject.Find("Player").GetComponent<Animator>();
        rotationZ = gameObject.transform.rotation.z;
        play = false;
        canMovePlatforms = false;
    }
    
    public void Update()
    {
        TurnIt(); 
        PlayDrums();
        if(rotationZ >= -2f && rotationZ <= 2f) // this is a constrain to the move platform script. Without it, player could move the platforms on any direction. With it, player can only move platforms vertically to the original perspective.
        {
            canMovePlatforms = true;
        }
        else
        {
            canMovePlatforms = false;
        }
    }

   
   public void TurnIt() // Method that makes the level rotate
    {
        if (Input.GetButton("Rotate") && movement.GetComponent<PlayerMovement>().onTurnPlat == true) // Only rotates when the player is holding the rotate button AND is on the rotation platform
        {
            play = true;
            animator.SetBool("drums", true);
            


            
            rotationZ -= Input.GetAxis("Horizontal") * speed * Time.deltaTime; // rotates gradually with a velocity that can be controlled on the inspector
            rotationZ = Mathf.Clamp(rotationZ, -90, 90); // This only allows the rotation between -90 and 90 degrees

            transform.rotation = Quaternion.Euler(0, 0, rotationZ); // the rotation itself


        }
        else
        {
            play = false;
            animator.SetBool("drums", false);

        }
      

    }
   

   public void PlayDrums() // This is how we change the sound only when the drums are activated

   {
       if (musicTrack <= 1f) // not allowing the track be less than 1
       {
           musicTrack = 1f;
       }
       if (musicTrack >= 2f) // not allowing the track be greater than 2
        {
           musicTrack = 2f;
       }

       if (play)
       {
           musicTrack += subtractValue * Time.deltaTime; // lowers the float to reach the special track

       }

       else
       {
           musicTrack += addValue * Time.deltaTime; // reaises the float to reach the regular track

       }
        
       music.RotateDrums(musicTrack); // plays the music
   }



}
