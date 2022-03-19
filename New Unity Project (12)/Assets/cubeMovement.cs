using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour
{
    GameObject parent;
    Rigidbody rigidbody;
    float copySpeed;
    float copyDistance;
    Vector3 startCoordinate;
    private void Awake()
    {
        

        rigidbody = GetComponent<Rigidbody>();

        parent = GameObject.Find("cubeCreator").gameObject;

        startCoordinate = parent.transform.position;

        copySpeed = parent.GetComponent<cubeCreateScript>().speed;

        copyDistance = parent.GetComponent<cubeCreateScript>().distance;

        gameObject.transform.parent = parent.transform;

        rigidbody.velocity = new Vector3(0, 0, copySpeed);
    }


    private void Update()
    {
      
       if(Vector3.Distance(gameObject.transform.position , parent.transform.position) >= copyDistance)
        {
            Destroy(gameObject);
        }

    }


}
