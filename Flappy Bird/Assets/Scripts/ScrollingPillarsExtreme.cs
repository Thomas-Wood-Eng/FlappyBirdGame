using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingPillarsExtreme : MonoBehaviour
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
        if (transform.position.x <= -1)
        {
            transform.position = new Vector2(1000f, 0f);
        }

    }
}
