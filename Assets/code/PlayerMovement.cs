using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public InputManager Input;
    public float Acceleration = 10f;
    public float MaxSpeed = 5f;
    [SerializeField] private Rigidbody2D _rb;

    public Vector2 Direction = Vector2.zero;

    protected void FixedUpdate()
    {
        Direction = Input.Player.Move.ReadValue<Vector2>();
        var speed = Acceleration * 10f;
        var lspeed = Time.deltaTime * 5f;
        var vel = new Vector2(Mathf.Lerp(_rb.velocity.x, 0, lspeed), Mathf.Lerp(_rb.velocity.y, 0, lspeed));
        _rb.velocity = new(Direction.x == 0 ? vel.x : _rb.velocity.x, Direction.y == 0 ? vel.y : _rb.velocity.y);

        if (Direction.magnitude == 0)
            return;

        if (_rb.velocity.magnitude <= 0.1f)
            _rb.velocity = Vector2.zero;

        _rb.AddForce(Direction * speed, ForceMode2D.Force);
    }

    protected void LateUpdate()
    {

        // clamp speed
        var vel = _rb.velocity;
        var isMovingDiagonally = Direction.x != 0 && Direction.y != 0;
        var maxSpeed = MaxSpeed;

        var vx = Mathf.Clamp(vel.x, -maxSpeed, maxSpeed);
        var vy = Mathf.Clamp(vel.y, -maxSpeed, maxSpeed);
        vel = new(vx, vy);

        _rb.velocity = vel;
    }
}
