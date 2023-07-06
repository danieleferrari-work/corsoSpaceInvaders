using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] float movementSpeed;
    [SerializeField] int life = 3;

    [Header("References")]
    [SerializeField] TMP_Text lifeText;
    [SerializeField] ParticleSystem explosionParticle;


    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        gameObject.transform.position += new Vector3(
            h * movementSpeed,
            0,
            v * movementSpeed);

        UpdateLifeText();
    }

    // // parte 1
    // // fai vedere che questo non viene stampato
    // void OnCollisionEnter(Collision other)
    // {
    //     Debug.Log($"Collision with {other.gameObject.name}");
    // }

    // parte 2 
    // fai vedere che questo invece viene stampato
    // perchè il bullet è Trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Const.Tags.Enemy))
        {
            Debug.Log($"Trigger enter with {other.gameObject.name}");
            life--;
            UpdateLifeText();

            if (life == 0)
                GameOver();
        }
    }

    void UpdateLifeText()
    {
        lifeText.text = life.ToString();
    }

    void GameOver()
    {
        Debug.LogWarning("GAME OVER");
        explosionParticle.gameObject.SetActive(true);

        GameObject.FindObjectOfType<GameManager>().GameOver();
    }
}