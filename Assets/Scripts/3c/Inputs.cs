using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
   // [SerializeField] private GameObject guitarWave;
    public float timer = 0;
    public bool canWave;
    private LevelRotation lvlrot;
    // Start is called before the first frame update
    void Start()
    {
       // guitarWave.SetActive(false);
        canWave = true;
    }

    // Update is called once per frame
    void Update()
    {

      


     /*   if (Input.GetKey(KeyCode.E) && canWave)
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
        */
       
    }


    
    public void ResetTimer()
    {
        timer = 0f;
    }


}
