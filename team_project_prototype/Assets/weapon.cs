using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject ammo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject ammos;

        if (Input.GetMouseButtonDown(0))
        {
            ammos = GameObject.Instantiate(ammo);
            ammos.transform.position = transform.position;
        }

        
    }
}
