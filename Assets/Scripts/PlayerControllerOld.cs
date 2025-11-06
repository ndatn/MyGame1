using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControllerOld : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Lấy input từ bàn phím (WASD hoặc mũi tên)
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2(moveX, moveY).normalized; // chuẩn hóa vector để đi chéo không nhanh hơn
    }

    private void FixedUpdate()
    {
        // Di chuyển nhân vật
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }
}
