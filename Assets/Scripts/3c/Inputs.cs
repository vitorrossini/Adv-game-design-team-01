using UnityEngine;

public class Inputs : MonoBehaviour
{

    // Was supposed to be the script with all the inputs, but i couldnt manage to make it in time.
    // This script deals with the input of the guitar (button activation), where it instantiates a collider to destroy the doors. It should last for 1 sec and plays the animation and new sound for 2 seconds, there after that it can be triggered again

    public ParametersSetByName music;
    public float musicTransition = 1f;
    public float musicTrack = 2f;
    [SerializeField] private GameObject wavePrefab;
    [SerializeField] private Transform playerPosition;
    public float timer;
    public bool triggerrr;
    private Animator animator;
    public float drumStartLoop;


    private void Start()
    {
        triggerrr = false;
        animator = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Guitar"))
        {
            TriggerTimer(); // starts a method that activates the timer
            animator.SetBool("guitar", true);
            
            GameObject newWave = Instantiate(wavePrefab); // creates the prefab in game (the guitar collider)
            newWave.transform.position = playerPosition.position; // the position its created is where the player is
        }
        
        else
        {
            animator.SetBool("guitar", false);
        }

        if (triggerrr)
        {
            PlayGuitar();
        }
       
        
    }

    public void TriggerTimer()
    {
        triggerrr = true;
    }

    public void PlayGuitar()
    {
        timer += Time.deltaTime;
        if (timer <= 2f)
        {
            music.UseGuitar(musicTrack - musicTransition);
        }

        if (timer > 2f)
        { 
            music.UseGuitar(musicTrack + musicTransition);
            timer = 0;
            triggerrr = false;
        }
    }

  

}