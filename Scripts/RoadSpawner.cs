using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> _roads;
    [SerializeField] float _roadLength;
    GameObject _road;

    void Start()
    {
        _road = Instantiate(_roads[Random.Range(0, _roads.Count - 1)], transform.position, Quaternion.identity);
    }

    void Update()
    {

    }

    public void SpawnRoads()
    {
        Vector3 position = new Vector3(0, 0, _road.transform.position.z + _roadLength);
        _road = Instantiate(_roads[Random.Range(0, _roads.Count - 1)], position, Quaternion.identity);
    }
}
