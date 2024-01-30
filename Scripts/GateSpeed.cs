using UnityEngine;

public class GateSpeed : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerMove playerMove = other.attachedRigidbody.GetComponent<PlayerMove>();
        playerMove.AddSpeed();
        Destroy(gameObject);
    }
}
