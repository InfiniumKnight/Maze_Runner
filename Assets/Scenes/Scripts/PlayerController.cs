using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f;

    private Rigidbody2D rb;

    private Vector3 movementDirection;

    public bool GameOver = false;

    public int score = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (GameOver == false && score < 1)
        {
            movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
        else if(GameOver == false && score >= 1)
        {
            movementSpeed = 0.0f;
            Invoke("LoadScene", 0.75f);
        }
        else
        {
            movementSpeed = 0.0f;
        }

        if (Input.GetKey(KeyCode.R))

        {

            if (GameOver == true)

            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            }

        }
    }

    void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
