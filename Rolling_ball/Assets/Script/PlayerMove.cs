using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class PlayerMove : MonoBehaviour
    {
        public float rotationSpeed = 45f; // Tốc độ xoay tính bằng độ mỗi giây

        void Update()
        {
            // Xoay đối tượng quanh trục z theo thời gian
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
    }
}

