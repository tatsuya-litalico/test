using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 1f;
    Rigidbody2D rd = default;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rd.AddForce(transform.right * (transform.rotation.z >= 0 ? speed : -speed), ForceMode2D.Impulse);
    }
}
