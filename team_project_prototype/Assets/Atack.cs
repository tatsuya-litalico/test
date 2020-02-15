using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack : MonoBehaviour
{
    [SerializeField]
    int density = 0;
    [SerializeField]
    GameObject bullet = null;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Instantiate(bullet, transform.position, new Quaternion(0, 0, 0, 0));
            b.transform.Rotate(0, 0, 180);
            b = null;
            //BossAtack();
        }
    }

    void BossAtack()
    {
        if(density < 1)
        {
            return;//0よりしたはエラー起こるので弾く
        }
        if(180 % density != 0)
        {
            return;//180の約数でなければreturn
        }
        for (int rad = 0; rad <= 180; rad += density)
        {
            GameObject b = Instantiate(bullet, transform.position, new Quaternion(0, 0, 0, 0));
            b.transform.Rotate(0, 0, rad);
            Debug.Log(rad);
        }
    }
}
