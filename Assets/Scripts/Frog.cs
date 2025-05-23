using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;

    enum MovementState { up, down, left, right }
    Animator anim;
    MovementState state;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
            // GetComponent<SpriteRenderer>().flipX = true;
            state = MovementState.right;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
             // GetComponent<SpriteRenderer>().flipX = false;
             state = MovementState.left;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
            state = MovementState.up;
        }
            if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
            state = MovementState.down;
        }
        anim.SetInteger("state", (int)state);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Car"))
        {
            Debug.Log("We lost !!!");

            Score.currentScore = 0;

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
