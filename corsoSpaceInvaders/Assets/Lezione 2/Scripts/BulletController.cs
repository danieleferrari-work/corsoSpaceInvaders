using System.Collections;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [Tooltip("Bullet lifetime in seconds")]
    [SerializeField] float lifeTime = 10;

    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;

        StartCoroutine(LifeCoroutine());
    }

    IEnumerator LifeCoroutine()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
