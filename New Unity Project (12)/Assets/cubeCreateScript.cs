using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCreateScript : MonoBehaviour
{
    public GameObject cube;
    public float timeToCreateNewCube;
    public float distance;
    public float speed;

    void Start()
    {
        StartCoroutine(createNewCube());
    }




    IEnumerator createNewCube()
    {
        yield return new WaitForSeconds(timeToCreateNewCube);

        Instantiate(cube);

        StartCoroutine(createNewCube());
    }
}
