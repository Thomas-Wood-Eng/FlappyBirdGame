using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollumPoolController : MonoBehaviour
{

    public int numCollums = 5; //number of active collums
    public GameObject collumPrefab;

    private GameObject[] collums;
    private Vector2 collumPosition = new Vector2(9.0f, -30.0f);
    private float spawnTime;
    public float spawnRate = 4f;
    public float spawnX = 5.4f;

    private int currCollum = 0;

    public float minY = -3f;
    public float maxY = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        collums = new GameObject[numCollums];
        //make the collums
        for (int i = 0; i < numCollums; i++)
        {
            collums[i] = (GameObject)Instantiate(collumPrefab, collumPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime = spawnTime + Time.deltaTime;
        if (spawnTime >= spawnRate)
        {

            spawnTime = 0;
            //set a random number from minY to maxY
            float spawnY = Random.Range(minY, maxY);
            //spawn in position
            collums[currCollum].transform.position = new Vector2(spawnX, spawnY);
            currCollum++;
            if (currCollum >= numCollums)
            {
                currCollum = 0;
            }
        }
    }
}
