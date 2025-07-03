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

    int _EnemyRandomSelect;
    int _EnemtSpawnRandomSelect;
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        _EnemyRandomSelect = Random.Range(0, _EnemySpawnNumber);
        _EnemtSpawnRandomSelect = Random.Range(0, _EnemtSpawnRandomSelect);
        obj = Instantiate(_EnemyList[_EnemyRandomSelect], _EnemySpawnerList[_EnemtSpawnRandomSelect].position,Quaternion.identity);       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
