using TMPro;
using UnityEngine;

namespace Lezione2Final
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] int life = 3;
        [SerializeField] float speed;
        [SerializeField] BulletController bulletPrefab;
        [SerializeField] TMP_Text lifeText;

        UIManager uiManager;


        private void Start()
        {
            uiManager = FindObjectOfType<UIManager>();

            UpdateLifeText();
        }

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

        void OnTriggerEnter(Collider other)
        {
            BulletController bullet = other.gameObject.GetComponentInParent<BulletController>();
            bool isEnemyBullet = bullet.tag == Const.Tags.Enemy;

            if (isEnemyBullet && bullet != null)
            {
                GameObject.Destroy(bullet.gameObject);
                TakeDamage();
            }
        }

        void TakeDamage()
        {
            life--;

            UpdateLifeText();

            if (life <= 0)
            {
                GameOver();
            }
        }

        void UpdateLifeText()
        {
            lifeText.text = life.ToString();
        }

        void GameOver()
        {
            GameObject.Destroy(gameObject);

            uiManager.OnGameOver();
        }
    }
}