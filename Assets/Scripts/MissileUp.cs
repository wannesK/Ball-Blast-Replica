using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileUp : MonoBehaviour
{
    public int missileDamage;
    public int speed = 20;

    private Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rigid.velocity = Vector2.up * speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Meteor") || other.CompareTag("Missile"))
        {
            Destroy(gameObject);
        }
    }

}