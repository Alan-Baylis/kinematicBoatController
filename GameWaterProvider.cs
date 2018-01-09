using KinematicVehicleSystem;
using UnityEngine;

namespace AiGame
{
    public class GameWaterProvider : MonoBehaviour, IWaterProvider
    {
        void Start()
        {

        }

        public float GetWaterLevel(float x, float z)
        {
            return WaterManager.Instance.GetWaterLevel(x, z);
        }

        public float GetStaticWaterLevel()
        {
            return WaterManager.Instance.GetStaticWaterLevel();
        }
    }
}