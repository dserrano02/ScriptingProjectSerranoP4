using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatatypeScript : MonoBehaviour
{
    void Start()
    {
        Vector3 pos = transform.position;
        pos = new Vector3(10, 4, 3);

        Transform tran = transform;
        tran.position = new Vector3(10, 4, 3);
    }
}