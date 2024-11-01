using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform targetPosition; // V? tr� c? ??nh ?? d?ch chuy?n ??n

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Ki?m tra n?u ??i t??ng va ch?m c� tag l� "Player"
        if (collision.CompareTag("Player"))
        {
            // D?ch chuy?n ??i t??ng "Player" ??n v? tr� c? ??nh
            collision.gameObject.transform.position = targetPosition.position;
        }
    }
}
