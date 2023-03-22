using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChangeShoulder : MonoBehaviour
{
  

    bool WeaponExist = true;
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
           gameObject.SetActive(false);
            WeaponExist = false;
        }
        if ( WeaponExist == false )
            
        {
            if (Input.GetMouseButtonDown(1))
            {


                gameObject.SetActive(true);
            }
        }
        
           if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.Translate(0f, 0f, -1.0f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.Translate(0f, 0f, 1.0f);
        }
    }
}
