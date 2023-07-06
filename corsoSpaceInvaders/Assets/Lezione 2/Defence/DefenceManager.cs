using UnityEngine;

public class DefenceManager : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Const.Tags.Enemy))
            GameObject.Destroy(gameObject);

        GameObject.Destroy(other.gameObject);
    }
}
