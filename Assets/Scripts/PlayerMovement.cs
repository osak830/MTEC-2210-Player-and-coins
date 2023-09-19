using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 5;
    Rigidbody2D rb;
    float xMove;
    float yMove;
    public TextMeshPro playerScoreText;
    int playerScore;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerScoreText.text = playerScore.ToString();
        xMove = Input.GetAxisRaw("Horizontal");
        yMove = Input.GetAxisRaw("Vertical");
    }

    public void IncrementScore(int scoreChange)
    {
        playerScore += scoreChange;
    }

    private void FixedUpdate()
    { 
        rb.velocity = new Vector2(xMove, yMove) * (Time.deltaTime * MovementSpeed);

    }
   

    
}
