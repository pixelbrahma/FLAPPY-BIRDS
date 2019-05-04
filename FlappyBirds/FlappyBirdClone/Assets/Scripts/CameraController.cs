using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private Vector2 playerPosition;

    private void Update()
    {
        playerPosition = GameObject.Find("Player").transform.position;
        transform.position = new Vector3(playerPosition.x, 0, -10f);
    }

}
