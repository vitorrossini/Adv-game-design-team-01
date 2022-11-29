using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatforms : MonoBehaviour
{
    public float addValue = 1.2f;
    public float subtractValue = -1.2f;
    public bool play;
    public float musicTrack = 2f;
    public float speed;
    float originalPos;
    public ParametersSetByName music;
    [SerializeField] public float limitDistance = 2f;
    

    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position.y;
        play = false;
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
