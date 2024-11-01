using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Script
{
    public class GamePlayCanvas : UICanvas
    {
        [SerializeField] private Text _levelText;
   
        [SerializeField] private GameObject WinMess;
        [SerializeField] private GameManager _gameManager;


        private void Awake()
        {
            if (_gameManager == null)
            {
                _gameManager = FindObjectOfType<GameManager>();
            }
        }

    
        private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            Debug.Log(scene.name);
           
        }


        public void PauseBtn()
        {
            UIManager.Instance.OpenUI<PauseCanvas>();
            Time.timeScale = 0;
        }

        private void Update()
        {
            UpdateLevelText();
            if (_gameManager == null)
            {
                _gameManager = FindObjectOfType<GameManager>();
            }
            if (_gameManager.hasWon)
            {
                WinMess.SetActive(true);
                
            }
            else
            {
                WinMess.SetActive(false);
            }
        }

        private void UpdateLevelText()
        {
            if (_levelText != null)
            {
                _levelText.text = SceneManager.GetActiveScene().name;
            }
        }

       
    }
}
