using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Vector2 screenBounds;
    public GameObject baseEnemy;

    void Start()
    {
        screenBounds =  Camera.main.ScreenToWorldPoint(new Vector3( Screen.width, Screen.height, 
                        Camera.main.transform.position.z));
        GenerateFourCorners();
    }

    void GenerateFourCorners()
    {
        Vector2 upperLeftPos = new Vector2(-screenBounds.x, screenBounds.y);
        Vector2 upperRightPos = new Vector2(screenBounds.x, screenBounds.y);

        GameObject upperLeft = Instantiate(baseEnemy, upperLeftPos, Quaternion.identity);
        GameObject upperRight = Instantiate(baseEnemy, upperRightPos, Quaternion.identity);
    }

}
