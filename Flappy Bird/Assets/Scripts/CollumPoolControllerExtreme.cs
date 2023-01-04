using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollumPoolControllerExtreme : MonoBehaviour
{

    public int numCollums = 5; //number of active collums
    public GameObject collumPrefabExtreme;

    private GameObject[] collums;
    public static CollumPoolControllerExtreme instance;
    private Vector2 collumPosition = new Vector2(9.0f, -150.0f);
    private float spawnTime;
    public float spawnRate = 4f;
    public float spawnX = 16.5f;
    public float spawnY = -21.5f;
    private Rigidbody2D CollumRB;
    private int currCollum = 0;

    public float minY = -23.5f;
    public float maxY = -19.8f;
    // Start is called before the first frame update
    void Start()
    {
        collums = new GameObject[numCollums];
        //make the collums
        for (int i = 0; i < numCollums; i++)
        {
            collums[i] = (GameObject)Instantiate(collumPrefabExtreme, collumPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime = spawnTime + Time.deltaTime;
        if (spawnTime >= spawnRate)
        {
          //  Debug.Log("DDDDDD");
            spawnTime = 0;
            //set a random number from minY to maxY
            spawnY = Random.Range(minY, maxY);
            //spawn in position
            collums[currCollum].transform.position = new Vector2(spawnX, spawnY);
            currCollum++;

           // CollumRB.velocity = new Vector2(0f, 0.5f);
            if (currCollum >= numCollums)
            {
                currCollum = 0;
            }
        }
    }
}
