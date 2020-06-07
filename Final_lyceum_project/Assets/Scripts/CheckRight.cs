using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRight : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            GetComponentInParent<PlayerController>().isBodyTolcheckRight = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            GetComponentInParent<PlayerController>().isBodyTolcheckRight = false;
        }
    }
}
