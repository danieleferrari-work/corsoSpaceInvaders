using UnityEngine;

public class PlayerShootingManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] BulletController bulletPrefab;
    [SerializeField] GameObject shootingPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BulletController bullet = Instantiate<BulletController>(bulletPrefab);
            bullet.transform.position = shootingPoint.transform.position;
        }
    }
}
