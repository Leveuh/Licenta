using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnZombie : MonoBehaviour
{
    public GameObject ZombiePRE;
    
    public Vector3 center;
    public Vector3 size;
   
    public GameObject Player;
    
    // Start is called before the first frame update
    void Start()
    {
        
        SpawnZombieRandom();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            {
            SpawnZombieRandom();
            
        }
        
        
    }
    public void SpawnZombieRandom()
    {   
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x/2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z/ 2));
      Player = GameObject.FindGameObjectWithTag("Player");
       Debug.Log($"player pos {Player.transform.position}");
        Instantiate(ZombiePRE, pos, Quaternion.LookRotation(Player.transform.position - pos, Vector3.up));
      
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(center, size);
        
    }
}
