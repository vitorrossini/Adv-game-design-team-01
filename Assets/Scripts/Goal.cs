using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public GameObject Win;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0f;
        Win.SetActive(true);

    }
}
