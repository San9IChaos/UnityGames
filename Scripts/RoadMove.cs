using UnityEngine;

public class RoadMove : MonoBehaviour
{
    [SerializeField] float _speed;

    private void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        DestroyRoad();
    }

    private void Move()
    {
        transform.Translate(-transform.forward * _speed * Time.fixedDeltaTime);
    }

    private void DestroyRoad()
    {
        if (transform.position.z < -42f)
        {
            Destroy(gameObject);
        }
    }
}
