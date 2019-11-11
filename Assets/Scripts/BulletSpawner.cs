using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag(Tags.GAME_MAMANGER_TAG).GetComponent<GameManager>();
    }

    void Update()
    {
        SpawnBullet();
    }

    public void SpawnBullet() {
        if (Input.GetMouseButtonDown(0) && !gameManager.IsGameFinished()) {
           GameObject bulletSpawn = Instantiate(bullet, transform.position, transform.rotation);   
        }
    }

}
