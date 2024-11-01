using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class DeActiveOnCLick : MonoBehaviour
    {
        void OnMouseDown()
        {
            // Làm cho đối tượng không hoạt động khi bị bấm vào
            gameObject.SetActive(false);
        }

    }
}



