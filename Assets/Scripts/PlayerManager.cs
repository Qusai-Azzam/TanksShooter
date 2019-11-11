using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private GameManager gameManager;
    void Start() {
        gameManager = GameObject.FindGameObjectWithTag(Tags.GAME_MAMANGER_TAG).GetComponent<GameManager>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(Tags.ENEMY_TAG))  {

            // Destroy Enemies
            GameObject[] enemies = GameObject.FindGameObjectsWithTag(Tags.ENEMY_TAG);
            for (int i = 0; i < enemies.Length; i++) {
                Destroy(enemies[i].gameObject);
            }

            // Destroy Bullets
            GameObject[] bullets = GameObject.FindGameObjectsWithTag(Tags.BULLET_TAG);
            for (int i = 0; i < bullets.Length; i++)
            {
                Destroy(bullets[i].gameObject);
            }


            // Finish the Game
            gameManager.FinishGame();
        }
    }
}
