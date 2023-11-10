using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translation : MonoBehaviour
{
    public Transform earth;
    public float orbitSpeed = 10f;

    void Update()
    {
        transform.RotateAround(earth.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
