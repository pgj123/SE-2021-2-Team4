
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class USharpTestObject : UdonSharpBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.up, 90.0f * Time.deltaTime);
    }
}
