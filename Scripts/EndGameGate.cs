using UnityEngine;

public class EndGameGate : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        PlayerMove playerMove = other.attachedRigidbody.GetComponent<PlayerMove>();
        FindObjectOfType<ShowEndMenu>().VisibleTrue();
        playerMove.Die();
    }
}
