using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Transform _transform;
    public float moveSpeed = 33;
    [SerializeField] private Animator player;
      

    void Start()
    {
        player = gameObject.GetComponent<Animator>();

        _transform = gameObject.GetComponent<Transform>();
    }

   
    // Update is called once per frame
    void Update()
    {
       
        if (!Input.anyKey)
        {
            player.SetFloat("MoveDirection", 0f);
            player.SetFloat("Forward", 0);
        }
        //////////////
        
          if(Input.GetKey(KeyCode.W))
        {
            
            transform.Translate(_transform.forward * Time.deltaTime * moveSpeed, Space.World);
            player.SetFloat("MoveDirection", 0f);
            player.SetFloat("Forward", 0.5f);

        }
        

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {

            transform.Translate(_transform.forward * Time.deltaTime * moveSpeed *2, Space.World);
            player.SetFloat("MoveDirection", 0f);
            player.SetFloat("Forward", 1f);
            
        }
       
        /////////////////////////////


        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(_transform.forward *-1 * Time.deltaTime * moveSpeed, Space.World);
            player.SetFloat("MoveDirection", 0.17f);
            player.SetFloat("Backwards", 1f);
        }

        ////////////////////////////////////
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_transform.right * -1 * Time.deltaTime * moveSpeed, Space.World);
            player.SetFloat("MoveDirection", 0.6f);
            player.SetFloat("Left", 1f);
        }
        ////////////////
        if (Input.GetKey(KeyCode.D))
        {   
            transform.Translate(_transform.right * Time.deltaTime * moveSpeed, Space.World);
            player.SetFloat("MoveDirection", 0.41f);
            player.SetFloat("Right", 1f);
        }

        ////////////
       if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            transform.Translate(_transform.right * Time.deltaTime * moveSpeed /2, Space.World);
            player.SetFloat("MoveDirection", 0.8f);
            player.SetFloat("RightFront", 1f);
        }

        ///////
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            transform.Translate(_transform.right * -1 * Time.deltaTime * moveSpeed /2, Space.World);
            player.SetFloat("MoveDirection", 1f);
            player.SetFloat("LeftFront", 1f);
        }
         var direction = Vector3.ProjectOnPlane(_transform.forward, Vector3.up);
        direction.Normalize();
        _transform.SetPositionAndRotation(_transform.position, Quaternion.LookRotation(direction , Vector3.up));

       

    }

   
}
