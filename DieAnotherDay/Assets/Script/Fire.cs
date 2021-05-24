using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject Bullet;
    public Transform firePosition;

    private float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Create bullet
            GameObject bullet = Instantiate(Bullet);
            Rigidbody2D rig = bullet.GetComponent<Rigidbody2D>();
            bullet.transform.position = firePosition.position;
            Vector2 look = Gunner.mousePosition - Gunner.playerPosition;
            rig.rotation = Mathf.Atan2(look.y, look.x) * Mathf.Rad2Deg - 90f;
            rig.velocity = look * speed / look.magnitude;
            Destroy(bullet, 3f);
        }
    }
}
