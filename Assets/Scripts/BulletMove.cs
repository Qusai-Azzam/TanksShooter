using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed;
    public GameObject explosion;

    void Start()
    {
        Destroy(gameObject, 1.5f);
    }
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Contains("Enemy"))
        {
            GameObject explosionEffect = Instantiate(explosion, collision.transform.position,collision.transform.rotation);
            Destroy(explosionEffect,1f);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
