using UnityEngine;

public class Inputs : MonoBehaviour
{
    public ParametersSetByName music;
    [SerializeField] private GameObject wavePrefab;
    [SerializeField] private Transform playerPosition;
    public float timer;
    public bool triggerrr;

    private void Start()
    {
        triggerrr = false;
    }
    void Update()
    {
        if (Input.GetButtonDown("Guitar"))
        {
            TriggerTimer();

            
            GameObject newWave = Instantiate(wavePrefab);
            newWave.transform.position = playerPosition.position;
        }

        if (triggerrr)
        {
            PlayGuitar();
        }
        music.UseGuitar2();
        
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
            music.UseGuitar1();
        }

        if (timer > 2f)
        {
            music.UseGuitar2();
            timer = 0;
            triggerrr = false;
        }
    }

}