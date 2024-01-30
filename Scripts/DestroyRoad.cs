using UnityEngine;

public class DestroyRoad : MonoBehaviour
{
    [SerializeField] GameObject road;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(road);
    }
}
