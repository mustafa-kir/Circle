using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDestroyController : MonoBehaviour
{
    [SerializeField] private float endXValue;
    void Update()
    {
        CheckLinePosition();
    }

    private void CheckLinePosition(){
        if (transform.position.x <= endXValue)
        {
            Destroy(gameObject);
        }
    }

}
