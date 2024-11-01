using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Script
{
    public class LoseCanvas : UICanvas
    {
        public Sprite OnVolume;
        public Sprite OffVolume;

        [SerializeField] private Image buttonImage;
        void Start()
        {
  
            UpdateButtonImage();
  
        }
        public void RetryBtn()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            UIManager.Instance.CloseUI<LoseCanvas>(0.1f);
            Debug.Log("dadada");
            
        }

        public void HomeBtn()
        {
            UIManager.Instance.CloseAll();
            Time.timeScale = 1; 
            SceneManager.LoadScene("Home");
            
            UIManager.Instance.OpenUI<HomeCanvas>();
            
        }
        public void SoundBtn()
        {
            SoundManager.Instance.TurnOn = !SoundManager.Instance.TurnOn;
            UpdateButtonImage();
           
        }

        private void UpdateButtonImage()
        {
            if (SoundManager.Instance.TurnOn)
            {
                buttonImage.sprite = OnVolume;
            }
            else
            {
                buttonImage.sprite = OffVolume;
            }
        }
    }
}