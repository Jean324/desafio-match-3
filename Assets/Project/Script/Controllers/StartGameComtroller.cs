using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gazeus.DesafioMatch3
{
    public class StartGameComtroller : MonoBehaviour
    {
        [SerializeField] private Material material;
        [SerializeField] private Color color;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            SliderValeu();
        }

        void SliderValeu()
        {
            material.color = color;

        }

    }
}
