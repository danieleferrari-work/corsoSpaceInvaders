using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] float speed;
   [SerializeField] BulletController bulletPrefab;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        gameObject.transform.position = new Vector3(
            transform.position.x + (h * speed),
            transform.position.y,
            transform.position.z + (v * speed));

        if (Input.GetKeyDown("space"))
            Shoot();
    }

    void Shoot()
    {
        BulletController bullet = GameObject.Instantiate(bulletPrefab);

        bullet.transform.position = gameObject.transform.position;
        bullet.transform.LookAt(transform.forward);
    }
}
