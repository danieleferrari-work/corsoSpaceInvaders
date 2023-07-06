using UnityEngine;

public class EnemyController : MonoBehaviour
{
    EnemiesShootController enemiesShootController;

    private void Start()
    {
        enemiesShootController = FindObjectOfType<EnemiesShootController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Const.Tags.Player))
        {
            enemiesShootController.onEnemyDestroyed.Invoke(this);
            Destroy(gameObject);
        }
    }
}