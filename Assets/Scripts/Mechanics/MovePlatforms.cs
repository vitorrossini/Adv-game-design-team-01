using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatforms : MonoBehaviour
{
    public float speed;
    float originalPos;
    public ParametersSetByName music;
    [SerializeField] public float limitDistance = 2f;
    

    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(0, verticalInput, 0);

        if (Input.GetButton("Platform"))
        {

            music.LevitatePiano(1f);
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
            music.LevitatePiano(2f);
        }
    }

       


}
