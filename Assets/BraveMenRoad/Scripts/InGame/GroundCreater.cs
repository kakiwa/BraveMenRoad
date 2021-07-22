using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 地面を配置する
/// </summary>
public class GroundCreater : MonoBehaviour
{
    [SerializeField]
    private GameObject groundPrefab = null;

    [SerializeField]
    private GameObject routePrefab = null;
    
    void Start()
    {
        // マップを並べる
        for (int i = 0; i < 50; ++i)
        {
            for (int j = 0; j < 5; ++j)
            {
                var groundObj = Instantiate(groundPrefab, this.transform);
                groundObj.transform.position = new Vector3(i, 0, j);
            }
        }
        
        // 道を並べる
        
    }
}
