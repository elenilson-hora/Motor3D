using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Unity Engine
    public Transform player;

    // Mathematic
    private Vector3 offset;

    private void Start()
    {
        // Distancia entre a camera e o player
        offset = transform.position - player.position;
    }

    // 15° metodo do MonoBehaviour
    private void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}
