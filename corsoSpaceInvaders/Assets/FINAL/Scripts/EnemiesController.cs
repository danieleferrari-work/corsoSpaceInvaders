using System.Linq;
using System.Collections;
using System;
using UnityEngine;
using System.Collections.Generic;

public class EnemiesController : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float secondsBetweenShoots;
    [SerializeField] float movementOffset;
    [SerializeField] float forwardStep;
    [SerializeField] GameObject bulletPrefab;

    bool movingLeft;
    float maxX;
    float minX;
    List<EnemyController> livingEnemies;

    Action directionChanged;
    public Action<EnemyController> enemyDefeated;


    void Start()
    {
        livingEnemies = GetComponentsInChildren<EnemyController>().ToList();

        float startXPosition = transform.position.x;
        maxX = startXPosition + movementOffset;
        minX = startXPosition - movementOffset;

        directionChanged += OnDirectionChanged;
        enemyDefeated += OnEnemyDefeated;
        
        StartCoroutine(ShootCoroutine());
    }

    void Update()
    {
        if (!movingLeft && transform.position.x > maxX)
        {
            movingLeft = true;
            directionChanged?.Invoke();
        }
        else if (movingLeft && transform.position.x < minX)
        {
            movingLeft = false;
            directionChanged?.Invoke();
        }

        int movementDirection = movingLeft ? -1 : 1;

        transform.position += new Vector3(
            movementDirection * movementSpeed,
            0,
            0);
    }

    void OnDirectionChanged()
    {
        transform.position += Vector3.back * forwardStep;
    }
    
    void OnEnemyDefeated(EnemyController enemy)
    {
        livingEnemies.Remove(enemy);
    }

    IEnumerator ShootCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(secondsBetweenShoots);
            Shoot();
        }
    }

    void Shoot()
    {
        EnemyController shootingEnemy = livingEnemies[UnityEngine.Random.Range(0, livingEnemies.Count)];

        GameObject bullet = GameObject.Instantiate(bulletPrefab);
        bullet.transform.position = shootingEnemy.transform.position;
        bullet.transform.LookAt(shootingEnemy.transform.forward);
    }
}
