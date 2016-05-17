using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
public class Spaceship : MonoBehaviour
{
    public float speed;
    public float shotDelay;
    public bool canShot;
    public GameObject bullet;
    public GameObject explosion;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Explosion()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }

    public void Shot(Transform origin)
    {
        Instantiate(bullet, origin.position, origin.rotation);
    }

    public Animator GetAnimator()
    {
        return animator;
    }
}
