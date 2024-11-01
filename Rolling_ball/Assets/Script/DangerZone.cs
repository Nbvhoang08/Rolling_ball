using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0;
            UIManager.Instance.OpenUI<LoseCanvas>();
        }
    }
    
}
