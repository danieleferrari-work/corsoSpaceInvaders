using UnityEngine;

namespace Lezione2b
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float movementSpeed;

        void Update()
        {
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");

            gameObject.transform.position += new Vector3(
                h * movementSpeed,
                0,
                v * movementSpeed);

        }
    }
}