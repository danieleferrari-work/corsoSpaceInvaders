using System.Collections;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float speed;

    Rigidbody rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        StartCoroutine(LifeTime(5));
    }

    void FixedUpdate()
    {
        rb.velocity =  transform.forward * speed;
    }

    IEnumerator LifeTime(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        GameObject.Destroy(gameObject);
    }
}
