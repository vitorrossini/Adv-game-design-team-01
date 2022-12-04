using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatforms : MonoBehaviour
{

    // Script that allows platforms being moved vertically by the player under certain conditions.

    [SerializeField] private GameObject warning;
    private LevelRotation lvl;
    [Header("Will it rotate with the level?")]
    public bool willRotate;
    
    [Header("Music")]
    public ParametersSetByName music;
    public float addValue = 1.2f;
    public float subtractValue = -1.2f;
    public bool play;
    public float musicTrack = 2f;
    
    [Header("Moving settings")]
    [SerializeField] public float limitDistance = 2f;
    public float speed;
    float originalPos;


    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        lvl = GameObject.Find("Level").GetComponent<LevelRotation>();
        animator = GameObject.Find("Player").GetComponent<Animator>();
        originalPos = transform.position.y;  // position where the platform is set when the game starts
        play = false;
        warning = GameObject.Find("Warning For Platforms").GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        
        PlayPiano();
        
        float verticalInput = Input.GetAxis("Vertical"); // reads the vertical input

        Vector3 direction = new Vector3(0, verticalInput, 0); // Adress the vertical input as the direction we want the platform to move (x direction)
        

        if (Input.GetButton("Platform") && lvl.GetComponent<LevelRotation>().canMovePlatforms) // if the button is pressed and you can move it
        {
            play = true;
            animator.SetBool("piano", true);


            
            transform.Translate(direction * speed * Time.deltaTime); // moves the platform gradually in the direction and speed determined

            if (transform.position.y <= (originalPos -limitDistance)) // if the platform reached the max distance down
            {
                transform.position = new Vector3(transform.position.x, (originalPos - limitDistance) , transform.position.z); // it remains on that limit
            }
            else if (transform.position.y >= (originalPos + limitDistance)) // if the platform reaches the max distance up
            {
                transform.position = new Vector3(transform.position.x, (originalPos + limitDistance) , transform.position.z); // it remains on that limit
            }
        }
        
        else
        {
            play = false;
            animator.SetBool("piano", false);

        }

        if (willRotate)
        {
            
            transform.rotation = Quaternion.Euler(Vector3.up); // Keeps its side up after rotating the level (Thanks Arthur)

        }

        if (Input.GetButton("Platform") && lvl.GetComponent<LevelRotation>().canMovePlatforms == false) // if you are pressing the move platform button but doesnt reach the conditions to move the platforms
        {
            warning.SetActive(true); // warning UI shows up

        }
        else
        {
            warning.SetActive(false);
        }

        

    }

    void PlayPiano()
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

        music.LevitatePiano(musicTrack);

    }

  
}
