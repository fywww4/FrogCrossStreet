using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
             GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
              GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
        }
            if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Car"))
        {
            Debug.Log("We lost !!!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
