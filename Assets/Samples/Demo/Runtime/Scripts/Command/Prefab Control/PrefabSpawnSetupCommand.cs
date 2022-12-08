using UnityEngine;

namespace BxUni.ScenarioBuilder.Sample.Demo
{
    [System.Serializable]
    public class PrefabSpawnSetupCommand : BaseCommand
    {
        [SerializeField] Setup[] m_setups;
        
        public Setup[] Setups => m_setups;
        
        #region class 
        
        [System.Serializable]
        public class Setup
        {
            [Header("固有ID")]
            [SerializeField] string m_id;
        
            [Header("生成するPrefab")]
            [SerializeField] GameObject m_spawnPrefab;
        
            /// <summary>
            /// 固有ID
            /// </summary>
            public string ID => m_id;
        
            /// <summary>
            /// 生成するPrefab
            /// </summary>
            public GameObject SpawnPrefab => m_spawnPrefab;
        }
        
        #endregion

    }
}