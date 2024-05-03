using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gazeus.DesafioMatch3
{
    public class MaterialContoller : MonoBehaviour
    {

        [SerializeField] private Material material;        
        [SerializeField] private Color color;

        [SerializeField] private Animator animator;
        [SerializeField] public Button buttonPlay;

        void Update()
        {
            SliderValeu();
        }

        private void SliderValeu()
        {
            material.color = color;            
        }

        public void PlayIntroAnimation()
        {
            animator.SetTrigger("StartIntro");
            buttonPlay.interactable = false;
        }

    }
}
