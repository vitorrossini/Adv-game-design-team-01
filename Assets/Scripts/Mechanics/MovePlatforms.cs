using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatforms : MonoBehaviour
{
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
        originalPos = transform.position.y;
        play = false;
        warning = GameObject.Find("Warning For Platforms").GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        
        PlayPiano();
        
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(0, verticalInput, 0);
        

        if (Input.GetButton("Platform") && lvl.GetComponent<LevelRotation>().canMovePlatforms)
        {
            play = true;
            animator.SetBool("piano", true);


            
            transform.Translate(direction * speed * Time.deltaTime);

            if (transform.position.y <= (originalPos -limitDistance))
            {
                transform.position = new Vector3(transform.position.x, (originalPos - limitDistance) , transform.position.z);
            }
            else if (transform.position.y >= (originalPos + limitDistance))
            {
                transform.position = new Vector3(transform.position.x, (originalPos + limitDistance) , transform.position.z);
            }
        }
        
        else
        {
            play = false;
            animator.SetBool("piano", false);

        }

        if (willRotate)
        {
            
            transform.rotation = Quaternion.Euler(Vector3.up);

        }

        if (Input.GetButton("Platform") && lvl.GetComponent<LevelRotation>().canMovePlatforms == false)
        {
            warning.SetActive(true);

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
