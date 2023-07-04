using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenusTrun : MonoBehaviour
{
    public GameObject venus = default;

    public GameObject sunObject = default;

    public float venusRevolution = 35.0f;

    public float venusRotation = 6.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(venus.transform.position, Vector3.right, venusRevolution * Time.deltaTime);

        transform.RotateAround(sunObject.transform.position, Vector3.up, venusRotation * Time.deltaTime);



    }
}
