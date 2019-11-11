using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    private GameManager gameManager;
    private void Start() {
        gameManager = GameObject.FindGameObjectWithTag(Tags.GAME_MAMANGER_TAG).GetComponent<GameManager>();
        StartCoroutine(StartSpawning());
    }

    public void SpawnEnemy() {
        if (!gameManager.IsGameFinished())
        {
            GameObject enemyClone = Instantiate(enemy, transform.position, Quaternion.identity);
        }
    }

    public IEnumerator StartSpawning()
    {
        InvokeRepeating("SpawnEnemy", 0.5f, 1.25f);
        yield return new WaitForEndOfFrame();
    }
}
