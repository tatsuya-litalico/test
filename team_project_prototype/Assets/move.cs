using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject player;
    public Vector3 velocity;
    private CharacterController controller;
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
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
        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y = 20;
            }
        }

        moveDirection.y -= 10 * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
