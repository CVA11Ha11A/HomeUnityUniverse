using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Serialization;
using UnityEngine;

public class SunTrun : MonoBehaviour
{
    public GameObject sun = default;

    public float sunSpin = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.RotateAround(sun.transform.position, Vector3.up, sunSpin * Time.deltaTime);

    }
}
