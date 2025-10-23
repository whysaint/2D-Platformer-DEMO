using System;
using UnityEngine;

public class PlatformerPlayer : MonoBehaviour
{
    public float speed = 4.5f;

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        Vector2 movement = new Vector2(deltaX, _rb.linearVelocity.y);
        _rb.linearVelocity = movement;
    }
}
