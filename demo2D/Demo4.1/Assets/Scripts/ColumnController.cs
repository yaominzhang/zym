using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnController : MonoBehaviour
{
    GameObject[] colum;
    public GameObject columnPrefab;
    public int columnMax = 5;
    public float spawnRate = 3f;
    public float yMin = -1f;
    public float yMax = 3.5f;
    public float xPos = 10f;
    float timeSinceLastSpawned;
    int currentColumn = 0;
    Vector2 originaiPos = new Vector2(-10, -20);
    // Start is called before the first frame update
    void Start()
    {
        colum = new GameObject[columnMax];
        for(int i = 0; i < columnMax; i++)
        {
            colum[i] = Instantiate(columnPrefab, originaiPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if (GameMode.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0f;
            float yPos = Random.Range(yMin, yMax);
            colum[currentColumn].transform.position = new Vector2(xPos, yPos);
            currentColumn++;
            if (currentColumn >= columnMax)
            {
                currentColumn = 0;
            }
        }
    }
}
