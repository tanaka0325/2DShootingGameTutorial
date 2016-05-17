using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public int speed = 10;
    public float lifeTime = 5;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
        Destroy(gameObject, lifeTime);
    }
}