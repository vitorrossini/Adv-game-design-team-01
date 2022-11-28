using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    [SerializeField] public GameObject door;
    private bool canOpenDoor;

    private void Start()
    {
        canOpenDoor = false;
    }

    private void Update()
    {
        if(canOpenDoor)
        {
            Destroy(door);
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 7)
        {
            canOpenDoor = true;
        }
    }
}
