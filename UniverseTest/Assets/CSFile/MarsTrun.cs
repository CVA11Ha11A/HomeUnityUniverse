using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarsTrun : MonoBehaviour
{
    public GameObject mars = default;

    public GameObject sunObject = default;


    public float marsSpin = 868.22f;

    public float marsTurnSpin = 24.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(mars.transform.position, Vector3.right, marsSpin * Time.deltaTime);

        transform.RotateAround(sunObject.transform.position, Vector3.up, marsTurnSpin * Time.deltaTime);

    }
}
