using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScene : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    private GameObject _enemy;
    void Update() {
        if (_enemy == null) {
            _enemy = Instantiate(_enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(0, 0, 0);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
        }
    }
}
