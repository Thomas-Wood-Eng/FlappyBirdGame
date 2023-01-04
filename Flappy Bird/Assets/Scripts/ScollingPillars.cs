using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScollingPillars : MonoBehaviour
{

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(GameController.scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -20.25)
        {
            transform.position = (Vector2)transform.position + new Vector2(0f, -100f);
        }

    }
}
