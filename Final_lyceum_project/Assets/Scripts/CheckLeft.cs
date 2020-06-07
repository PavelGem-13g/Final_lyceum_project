using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLeft : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            GetComponentInParent<PlayerController>().isBodyTolcheckLeft = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            GetComponentInParent<PlayerController>().isBodyTolcheckLeft = false;
        }
    }
}
