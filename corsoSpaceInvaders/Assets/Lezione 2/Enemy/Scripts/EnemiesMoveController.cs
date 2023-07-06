using UnityEngine;

public class EnemiesMoveController : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float movementOffset;
    [SerializeField] float forwardStep;

    float maxX;
    float minX;
    Vector3 movementDirection;


    void Start()
    {
        float startXPosition = transform.position.x;
        maxX = startXPosition + movementOffset;
        minX = startXPosition - movementOffset;

        movementDirection = transform.right;
    }

    void Update()
    {
        if (transform.position.x > maxX
            || transform.position.x < minX)
            InvertMovementDirection();

        transform.position += movementDirection * movementSpeed;
    }

    void InvertMovementDirection()
    {
        movementDirection *= -1;
        transform.position += transform.forward * forwardStep;
    }
}