using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStageCreate : MonoBehaviour
{
    [SerializeField]
    List<GameObject> _FieldBlock;

    int r;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 15; i++) 
        {
            for (int j = 0; j < 15; j++)
            {
                Instantiate(_FieldBlock[r], new Vector3(i, 0, j), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        r = Random.Range(0, _FieldBlock.Count);
    }
}
