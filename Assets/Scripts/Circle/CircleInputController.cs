using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInputController : MonoBehaviour
{
    [SerializeField] private CircleDataTransmitter circleDataTransmitter;
    public bool isTounch = false;

    void Update()
    {
        HandleCircleInput();
    }

    private void HandleCircleInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isTounch = true;
            circleDataTransmitter.IncraseScoreValue();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isTounch = false;
        }
    }
}
