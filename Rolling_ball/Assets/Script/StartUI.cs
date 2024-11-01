using UnityEngine;

namespace Script.UI
{
    public class StartUI : MonoBehaviour
    {
        void Start()
        {
            UIManager.Instance.OpenUI<HomeCanvas>();
        }
    }
}