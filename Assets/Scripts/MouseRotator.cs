using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotator : MonoBehaviour
{
    public float offsetAngle=0;
    private GameManager gameManager;

    void Start() {
        gameManager = GameObject.FindGameObjectWithTag(Tags.GAME_MAMANGER_TAG).GetComponent<GameManager>();
    }
    void Update()
    {
        if (!gameManager.IsGameFinished()) {
            MoveCursorToMousePosition();
        }
        else {
            transform.rotation = Quaternion.identity;
        }
    }

    private void MoveCursorToMousePosition()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotation_z = Mathf.Atan2(difference.y , difference.x) * Mathf.Rad2Deg;

        if (rotation_z >= 0 && rotation_z <= 180) {
            transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + offsetAngle);
        }
    }

}
