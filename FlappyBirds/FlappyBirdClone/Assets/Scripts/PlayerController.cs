using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    private Rigidbody2D rb;
    private string text;
    bool game = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        text = " ";
    }

    private void Update()
    {
        if (game)
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpForce);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        game = false;
        rb.velocity = Vector2.zero;
        text += " GAME OVER !! ";
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(transform.position.x, transform.position.y, 100, 200), text);
    }
}
