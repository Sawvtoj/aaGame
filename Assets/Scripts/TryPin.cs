using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryPin : MonoBehaviour
{
    private bool isPinned = false;

    public static float speed = 40f;
    public Rigidbody2D rb;

    void Update()
    {
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            isPinned = true;
            Score.PinCount++;
        }
        else if (col.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

