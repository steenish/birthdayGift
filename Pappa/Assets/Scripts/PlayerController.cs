using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

#pragma warning disable
    [SerializeField]
    private Rigidbody2D rigidbody;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private float speed = 1.0f;
    [SerializeField]
    private float movementSmoothing = 0.05f;
#pragma warning restore

    private AudioManager audioManager;
    private bool facingRight = true;
    private LayerMask groundMask;
    private Vector3 velocity;

    private void Start() {
        audioManager = AudioManager.instance;
        audioManager.Play("Theme");
    }

    void Update() {
        float move = 0.0f;

        move = Input.GetAxis("Horizontal");

        Move(move);
    }

    private void Move(float move) {

        Vector3 targetVelocity = new Vector2(move * speed, rigidbody.velocity.y);
        rigidbody.velocity = Vector3.SmoothDamp(rigidbody.velocity, targetVelocity, ref velocity, movementSmoothing);

        animator.SetFloat("Speed", Mathf.Abs(rigidbody.velocity.x));

        if ((move < 0 && facingRight) || (move > 0 && !facingRight)) {
            Flip();
        }
    }

    private void Flip() {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        facingRight = !facingRight;
    }
}
