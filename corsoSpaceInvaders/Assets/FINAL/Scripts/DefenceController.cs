using UnityEngine;

public class DefenceController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        BulletController bullet = other.gameObject.GetComponentInParent<BulletController>();
        bool isEnemyBullet = bullet.tag == Const.Tags.Enemy;

        if (bullet != null)
        {
            Destroy(bullet.gameObject);

            if (isEnemyBullet)
                Destroy(gameObject);
        }
    }
}
