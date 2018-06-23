using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBar : MonoBehaviour {

    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _moveForce;
    [SerializeField] private float _maxSpeed;
    public CircleCollider2D fishbowl;

    private void FixedUpdate()
    {

        if (Input.GetButton("Horizontal"))
        {
            float axis = Input.GetAxis("Horizontal");
            Vector2 force = new Vector2(axis * _moveForce, 0);
            _rigidbody.AddForce(force);
        }

        if (Mathf.Abs(_rigidbody.velocity.x) > _maxSpeed)
        {
            _rigidbody.velocity = Mathf.Sign(_rigidbody.velocity.x) * new Vector2(_maxSpeed, _rigidbody.velocity.y);
        }


    }

    private void LateUpdate()
    {
        transform.position = fishbowl.bounds.ClosestPoint(transform.position);
    }
}
