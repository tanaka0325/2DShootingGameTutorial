using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    Spaceship spaceship;

    void Start()
    {
        spaceship = GetComponent<Spaceship>();
        spaceship.Move(transform.up * -1);
    }

}
