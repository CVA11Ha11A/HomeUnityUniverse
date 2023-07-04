using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercuryTrun : MonoBehaviour
{
    public GameObject mercury = default;

    public GameObject sunObject = default;

    public float mercuryRevolution = 30.0f;

    public float sunRotation = 10.8f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(mercury.transform.position, Vector3.right, mercuryRevolution * Time.deltaTime);

        transform.RotateAround(sunObject.transform.position, Vector3.up, sunRotation * Time.deltaTime);

    }
}
