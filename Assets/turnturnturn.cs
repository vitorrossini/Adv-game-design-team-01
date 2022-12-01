using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnturnturn : MonoBehaviour
{
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 5f * 2f * Time.deltaTime, Space.Self);
    }
}
