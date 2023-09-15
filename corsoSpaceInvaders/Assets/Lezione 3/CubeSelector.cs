using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeSelector : MonoBehaviour
{
    public List<SimpleCube> cubes = new List<SimpleCube>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        if (Input.GetKeyDown(KeyCode.Alpha1))
            SelectCube(0);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            SelectCube(1);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            SelectCube(2);
        if (Input.GetKeyDown(KeyCode.Alpha4))
            SelectCube(3);
        if (Input.GetKeyDown(KeyCode.Alpha5))
            SelectCube(4);
        if (Input.GetKeyDown(KeyCode.Alpha6))
            SelectCube(5);
        if (Input.GetKeyDown(KeyCode.Alpha7))
            SelectCube(6);
    }

    private void SelectCube(int index)
    {
        cubes.ForEach(x => x.SetSelected(false));

        if (cubes.Count > index)
            cubes[index].SetSelected(true);
    }
}
