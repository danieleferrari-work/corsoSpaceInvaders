using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float speed;

    Rigidbody rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity =  transform.forward * speed;
    }
}
