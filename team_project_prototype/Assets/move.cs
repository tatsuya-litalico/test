using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject player;
    public Vector2 velocity;
    public float jump_power = 1000f;
    private Rigidbody2D rb;
    private bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
    }

    private void OnCollisonEnter(Collision collision)
    {
        Destroy(player);
//        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        // 走り
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += transform.right * velocity.y * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position -= transform.right * velocity.y * Time.deltaTime;
        }

        //ジャンプ
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(transform.up * jump_power);
            }
        }
    }
}
