using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    [SerializeField] private Transform obstaclePrefab;
    private float spawnDistanceX;
    private float spawnOffsetY;
    private float playerPosition;
    private float lastSpawnPosition = 0f;
    private float distance = 4f;

    private void Update()
    {
        playerPosition = GameObject.Find("Player").transform.position.x;
        while(playerPosition > (lastSpawnPosition - (Camera.main.orthographicSize * Camera.main.aspect)))
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        spawnDistanceX = Random.Range(4f, 7f);
        spawnOffsetY = Random.Range(2f, 9f);
        Transform obs = Instantiate(obstaclePrefab, new Vector2((lastSpawnPosition + spawnDistanceX), -spawnOffsetY),
        Quaternion.identity);
        lastSpawnPosition = obs.position.x;
        Instantiate(obstaclePrefab, (obs.position + new Vector3(0f, distance + obs.localScale.y, 0f)),
            Quaternion.identity);
    }
}
