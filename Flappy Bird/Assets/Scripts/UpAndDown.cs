using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    private Rigidbody2D CollumRB;
    private float Y;
    // Start is called before the first frame update
    void Start()
    {
        CollumRB = GetComponent<Rigidbody2D>();
        Y = Random.Range(0.5f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        CollumRB.velocity = new Vector2(GameController.scrollSpeed, Y);
        if (transform.position.y >= -20)
        {
            Y = Random.Range(-3f, -1f);
            CollumRB.velocity = new Vector2(GameController.scrollSpeed, Y);
        }
        if (transform.position.y <= -23.5)
        {
            Y = Random.Range(1f,3f);
            CollumRB.velocity = new Vector2(GameController.scrollSpeed, Y);
        }
    }
}
