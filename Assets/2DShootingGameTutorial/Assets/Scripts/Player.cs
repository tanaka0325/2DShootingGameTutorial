using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed = 5;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(x, y).normalized;

        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
