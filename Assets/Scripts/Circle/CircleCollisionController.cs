﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class CircleCollisionController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Line"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
