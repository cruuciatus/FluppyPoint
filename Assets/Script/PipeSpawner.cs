using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    [SerializeField] private float spawnRate = 2;
    private float timer = 0;
    [SerializeField] private float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
              timer = 0;
        }

    }

    private void SpawnPipe()
    {
        float lowerPoint = transform.position.y - heightOffset;
        float   highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(10, Random.Range(lowerPoint, highestPoint),0), transform.rotation);
    }
}
