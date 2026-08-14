using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Unity Engine
    private Rigidbody rb;

    // Mathematic
    private Vector3 move;

    // C#
    public float speed = 10;
    private int point;

    // UI
    public TextMeshProUGUI textMesh;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //Pegar o Input com Player Intupt(send maneger)
    private void OnMove(InputValue inputValue)
    {
        Vector2 vector2 = inputValue.Get<Vector2>();
        move = new Vector3(vector2.x, 0f, vector2.y);
    }

    // 5° metodo do MonoBehaviour
    private void FixedUpdate()
    {
        rb.AddForce(move * speed);
    }

    // 6° metodo do MonoBehaviour
    private void OnTriggerEnter(Collider other)
    {
        // Pegar moeda
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            point++;

            textMesh.text = "Points: " + point;
        }
    }
}
