using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    Spaceship spaceship;

    IEnumerator Start()
    {
        while (true)
        {
            spaceship = GetComponent<Spaceship>();
            spaceship.Shot(transform);
            yield return new WaitForSeconds(spaceship.shotDelay);
        }
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(x, y).normalized;
        spaceship.Move(direction);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        string layerName = LayerMask.LayerToName(c.gameObject.layer);

        if (layerName == "Bullet (Enemy)")
        {
            Destroy(c.gameObject);
        }

        if (layerName == "Bullet (Enemy)" || layerName == "Enemy")
        {
            spaceship.Explosion();
            Destroy(gameObject);
        }
    }
}
