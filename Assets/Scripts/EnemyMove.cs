using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Vector3 playerPosition;
    public float speed;
    public float offsetAngle;

    void Start()
    {
        playerPosition = GameObject.Find(Tags.PLAYER_TAG).transform.position;

        // Rotate the enemy tank towerd the player position
        Vector3 difference = playerPosition - transform.position;
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + offsetAngle);
    }

    void Update()
    {
       transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
}
