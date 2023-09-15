using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SimpleCube
    : MonoBehaviour
{
    public GameObject selector;
    public GameObject collisionText;
    public GameObject triggerText;
    public float movementSpeed = 1;
    

    bool selected = false;
    Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        if (selected == false)
            return;

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        gameObject.transform.position += new Vector3(
            h * movementSpeed,
            v * movementSpeed,
            0);
    }

    public void SetSelected(bool selected)
    {
        selector.gameObject.SetActive(selected);
        this.selected = selected;

        if (selected == false)
            transform.position= startPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerText.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        triggerText.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collisionText.SetActive(true);
    }

    private void OnCollisionExit(Collision collision)
    {
        collisionText.SetActive(false);
    }
}
