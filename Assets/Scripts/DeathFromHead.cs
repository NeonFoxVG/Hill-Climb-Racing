using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathFromHead : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Manager.instance.GameOver();
        }
    }
}
