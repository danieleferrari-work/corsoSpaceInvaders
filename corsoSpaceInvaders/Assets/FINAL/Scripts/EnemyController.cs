using UnityEngine;

public class EnemyController : MonoBehaviour
{
    EnemiesController enemiesController;

    
    void OnDestroy()
    {
        enemiesController.enemyDefeated(this);
    }
}
