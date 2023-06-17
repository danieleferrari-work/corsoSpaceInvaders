using UnityEngine;

public class EndlessRotation : MonoBehaviour
{

    [SerializeField] Vector3 rotationAxis;
    [SerializeField] float rotationSpeed;

    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
