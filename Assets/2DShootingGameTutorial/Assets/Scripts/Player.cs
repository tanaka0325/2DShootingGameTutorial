using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    Spaceship spaceshp;

    IEnumerator Start()
    {
        while (true)
        {
            spaceshp = GetComponent<Spaceship>();
            spaceshp.Shot(transform);
            yield return new WaitForSeconds(spaceshp.shotDelay);
        }
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(x, y).normalized;
        spaceshp.Move(direction);
    }
}
