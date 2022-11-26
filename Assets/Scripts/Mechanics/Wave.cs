using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    private bool isActive;
    private float timer;
   

    // Start is called before the first frame update
    public void Initialize(Vector3 direction)
    {
        isActive = true;
        Debug.LogError("instantialized");
    }

   /* public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("button"))
        {
            Debug.Log("open the door man");
        }
    }*/
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            Destroy(gameObject);
            Debug.LogError("Destroyed");
        }
    }
}
