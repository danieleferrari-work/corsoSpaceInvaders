using UnityEngine;

namespace Lezione2Final
{
    public class EnemyController : MonoBehaviour
    {
        EnemiesController enemiesController;

        private void Awake()
        {
            enemiesController = FindObjectOfType<EnemiesController>();
        }

        void OnDestroy()
        {
            enemiesController.enemyDefeated(this);
        }

        void OnTriggerEnter(Collider other)
        {
            BulletController bullet = other.gameObject.GetComponentInParent<BulletController>();
            bool isPlayerBullet = bullet.tag == Const.Tags.Player;

            if (isPlayerBullet && bullet != null)
            {
                GameObject.Destroy(bullet.gameObject);
                GameObject.Destroy(gameObject);
            }
        }
    }
}