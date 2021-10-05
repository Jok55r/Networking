using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : NetworkBehaviour
{
    public float speed = 1;
    void Move()
    {
        if (isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("Horizontal") * speed;
            float moveVertical = Input.GetAxis("Vertical") * speed;
            Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
            transform.position = transform.position + movement;
        }
    }
    private void Update()
    {
        Move();
    }
}