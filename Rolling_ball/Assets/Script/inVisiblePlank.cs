using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inVisiblePlank : MonoBehaviour
{
   
    public float fadeDistance = 5.0f; // Khoảng cách để bắt đầu làm mờ
    public float fadeSpeed = 2.0f; // Tốc độ làm mờ

    private Transform player;
    private SpriteRenderer spriteRenderer;
    private Color originalColor;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Start()
    {
        // Tìm đối tượng Player bằng tag
        

        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;

        // Đặt đối tượng ban đầu trong suốt
        Color transparentColor = originalColor;
        transparentColor.a = 0;
        spriteRenderer.color = transparentColor;
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > fadeDistance)
        {
            // Làm mờ đối tượng
            Color newColor = spriteRenderer.color;
            newColor.a = Mathf.Lerp(newColor.a, 0, fadeSpeed * Time.deltaTime);
            spriteRenderer.color = newColor;
        }
        else
        {
            // Hiện hình đối tượng
            Color newColor = spriteRenderer.color;
            newColor.a = Mathf.Lerp(newColor.a, originalColor.a, fadeSpeed * Time.deltaTime);
            spriteRenderer.color = newColor;
        }
    }
}
