using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> _EnemyList;
    [SerializeField]
    List<Transform> _EnemySpawnerList;
    [SerializeField]
    int _EnemySpawnNumber = 0;

    int r;
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        r = Random.Range(0, _EnemyList.Count);
        obj = Instantiate(_EnemyList, _EnemySpawnerList[r].position,Quaternion.identity);   
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
