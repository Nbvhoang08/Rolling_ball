using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

namespace Script
{
    public class PauseCanvas : UICanvas
    {
        public Sprite OnVolume;
        public Sprite OffVolume;

        [SerializeField] private Image buttonImage;
        void Start()
        {
  
            UpdateButtonImage();
  
        }
        public void Resume()
        {
            Time.timeScale = 1;
            UIManager.Instance.CloseUI<PauseCanvas>(0.2f);
            
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