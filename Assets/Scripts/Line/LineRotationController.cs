using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRotationController : MonoBehaviour
{
    private float randomRotation;
    private float rotationValue = 20 ;

    void Start()
    {
        GenerateRandomRotationValue();
        SetLineRotation();
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void GenerateRandomRotationValue()
    {
        randomRotation = Random.Range(-rotationValue, rotationValue);
    }

    private void SetLineRotation()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, randomRotation);
    }
}
