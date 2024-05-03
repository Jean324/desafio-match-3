using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Gazeus.DesafioMatch3.Views
{
    public class ParticleController : MonoBehaviour
    {
        [SerializeField] private TileSpotView _tileSpotPrefab;

        //private GameObject[][] _tiles;
        private TileSpotView[][] _tileSpots;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void ParticlePosition(List<Vector2Int> matchedPosition)
        {
            for (int i = 0; i < matchedPosition.Count; i++)
            {
                Vector2Int position = matchedPosition[i];

                //Destroy(_tiles[position.y][position.x]);

                //_tiles[position.y][position.x] = null;

                SimpleMatchEffect (matchedPosition);

            }

        }

        private void SimpleMatchEffect(List<Vector2Int> matchedPosition)
        {

            //if (matchedPosition.Count > 3)
            //{
            //Debug.Log("Contagem: " + matchedPosition.Count);

            //}
            for (int i = 0; i < matchedPosition.Count; i++)
            {
                Vector2Int position = matchedPosition[i];

                ParticleSystem particle = _tileSpots[position.y][position.x].GetComponentInChildren<ParticleSystem>();
                particle.Play();

            }

        }

    }
}
