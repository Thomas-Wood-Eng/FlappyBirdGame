using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackgroundExtreme : MonoBehaviour
{

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-10f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -1)
        {
           // Debug.Log("Reseey");
            transform.position = (Vector2)transform.position + new Vector2(2 * 20.25f, 0f);
        }

    }
}
