using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] RoadSpawner _roadSpawner;

    private void OnTriggerEnter(Collider other)
    {
        _roadSpawner.SpawnRoads();
    }
}
