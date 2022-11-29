using UnityEngine;

public class Inputs : MonoBehaviour
{
    public ParametersSetByName music;
    [SerializeField] private GameObject wavePrefab;
    [SerializeField] private Transform playerPosition;
    public float timer;

    void Update()
    {
        if (Input.GetButtonDown("Guitar"))
        {
            
            PlayGuitar();
            GameObject newWave = Instantiate(wavePrefab);
            newWave.transform.position = playerPosition.position;
        }
        
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
        }
    }

}