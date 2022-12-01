using UnityEngine;

public class Inputs : MonoBehaviour
{
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
            TriggerTimer();
            animator.SetBool("guitar", true);
            
            GameObject newWave = Instantiate(wavePrefab);
            newWave.transform.position = playerPosition.position;
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

    public void DrumsLoop()
    {
       animator.Play("DrumsLoop");
    }

}