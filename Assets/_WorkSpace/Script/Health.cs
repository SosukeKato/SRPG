using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    float _maxHP;

    public float _nowHP;

    void HP()
    {
        if (_nowHP >= _maxHP)
        {
            _nowHP = _maxHP;
        }
        if (_nowHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
