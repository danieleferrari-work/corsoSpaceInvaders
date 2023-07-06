using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera topCamera;
    [SerializeField] CinemachineVirtualCamera fpsCamera;


    void Start()
    {
        topCamera.gameObject.SetActive(true);
        fpsCamera.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            topCamera.gameObject.SetActive(!topCamera.gameObject.activeInHierarchy);
            fpsCamera.gameObject.SetActive(!fpsCamera.gameObject.activeInHierarchy);
        }

    }

}
