using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Car_Script : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
    }
}
