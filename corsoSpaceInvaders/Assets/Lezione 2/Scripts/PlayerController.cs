using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] int life = 3;


    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        gameObject.transform.position += new Vector3(
            h * movementSpeed,
            0,
            v * movementSpeed);
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
        Debug.Log($"Trigger enter with {other.gameObject.name}");
        life--;

        if (life == 0)
            Debug.LogWarning("GAME OVER");
    }
}