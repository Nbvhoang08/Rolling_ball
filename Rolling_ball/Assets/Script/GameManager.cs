using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
namespace Script
{
    public class GameManager : MonoBehaviour
    {
        public bool hasWon = false;

        void Awake()
        {
            hasWon = false; 
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                hasWon = true;
                StartCoroutine(nextsence());
                // Stop player movement
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.velocity = Vector2.zero;
                    other.transform.position = transform.position;
                }
            }
        }
        IEnumerator nextsence()
        {
            yield return new WaitForSeconds(0.5f);
            LevelManager.Instance.SaveGame();
            yield return new WaitForSeconds(1);
            //UIManager.Instance.CloseUIDirectly<GamePlayCanvas>();
            SwitchToNextScene();
        }
        public void SwitchToNextScene()
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
  
