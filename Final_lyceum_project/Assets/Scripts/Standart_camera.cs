using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Standart_camera : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(true);
    }
    void Update()
    {
        if (FindObjectOfType<PlayerController>() != null)
        {
            gameObject.SetActive(false);
        }
    }
}
