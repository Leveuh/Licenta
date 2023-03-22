using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMove : MonoBehaviour
{
    public float moveSpeed = -3;

   

    void Update()
    {
        transform.Translate(Vector3.forward *-1 * Time.deltaTime * moveSpeed, Space.World);
        
    }
}
