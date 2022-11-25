using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    // THIS SCRIPT DOES NOT WORK AND I DONT KNOW WHY

    private GameObject guitarWave;
    public float timer = 0;
    public bool canWave;
    // Start is called before the first frame update
    void Start()
    {

        guitarWave = GameObject.Find("wave").GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E) && canWave)
        {
            GuitarWave();

        }



    }


    public void GuitarWave()
    {
        
            guitarWave.SetActive(true);

            timer += Time.deltaTime;
            canWave = false;
            if (timer >= 1f)
            {
                guitarWave.SetActive(false);

            }

            else if (timer >= 2f)
            {
                canWave = true;
                ResetTimer();

            }
        

    }


    public void ResetTimer()
    {
        timer = 0f;
    }


}
