using System;
using UnityEngine;

namespace Config
{
    [CreateAssetMenu(menuName = "EcsCoins/Game Config")]
    public class GameConfig : ScriptableObject, IConfig
    {
        [SerializeField, Range(0f, 1f)] 
        private float _coinsDensity;
        public float CoinsDensity => _coinsDensity;

        [SerializeField] 
        private float _totalTime;
        public float TotalTime => _totalTime;

        [SerializeField] 
        private float _playerSpeed;
        public float PlayerSpeed => _playerSpeed;

        [SerializeField, Range(1, 100)] 
        private int _arenaSizeX = 20;
        public int ArenaSizeX => _arenaSizeX;

        [SerializeField, Range(1, 100)]
        private int _arenaSizeY = 20;
        public int ArenaSizeY => _arenaSizeY;

        [SerializeField, Range(0f, 120f)]
        private float _coinRotationSpeed = 20;
        public float CoinRotationSpeed => _coinRotationSpeed;
    }
}