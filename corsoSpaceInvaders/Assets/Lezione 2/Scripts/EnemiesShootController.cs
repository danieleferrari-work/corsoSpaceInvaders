using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemiesShootController : MonoBehaviour
{

    [Tooltip("Number of bullets per second")]
    [SerializeField] float fireRate = 1;
    [SerializeField] GameObject bulletPrefab;

    private float fireDelay;
    public List<EnemyController> enemies = new List<EnemyController>();


    void Start()
    {
        fireDelay = 1 / fireRate;
        enemies = GetComponentsInChildren<EnemyController>().ToList();

        StartCoroutine(ShootCoroutine());
    }

    EnemyController GetRandomEnemy()
    {
        int randomIndex = Random.Range(0, enemies.Count);

        return enemies[randomIndex];
    }

    IEnumerator ShootCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(fireDelay);

            // parte 1
            // il proiettile viene spawnato nella posizione del nemico ma come figlio del nemico
            // questo significa che anche il proiettile si muoverà con il nemico
            GameObject.Instantiate(bulletPrefab, GetRandomEnemy().transform);

            // //  parte 2
            // // in questo modo il proiettile viene spawnato nella root ma poi spostato nella posizione del nemico
            // var bullet = GameObject.Instantiate(bulletPrefab);
            // bullet.transform.position = GetRandomEnemy().transform.position;
        }
    }
}
