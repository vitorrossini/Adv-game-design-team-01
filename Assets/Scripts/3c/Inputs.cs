using UnityEngine;

public class Inputs : MonoBehaviour
{
    public ParametersSetByName music;
    [SerializeField] private GameObject wavePrefab;
    [SerializeField] private Transform playerPosition;

    void Update()
    {
        if (Input.GetButtonDown("Guitar"))
        {
            
            music.UseGuitar1();
            GameObject newWave = Instantiate(wavePrefab);
            newWave.transform.position = playerPosition.position;
        }
        else
        {
            music.UseGuitar2();
        }
    }
}