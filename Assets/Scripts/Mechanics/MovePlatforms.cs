using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatforms : MonoBehaviour
{
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
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position.y;
        play = false;
        //willRotate = false;
    }

    // Update is called once per frame
    void Update()
    {
        PlayPiano();
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(0, verticalInput, 0);

        if (Input.GetButton("Platform"))
        {
            play = true;

            
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
            
        }

        if (willRotate)
        {
            Debug.LogWarning("Testing");
                transform.rotation = Quaternion.Euler(Vector3.up);
            
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
