using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject BulletPre;
    public float BulletSpeed = 50;
    public Vector3 center;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBullet();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            SpawnBullet();
            transform.Translate(Vector3.forward * Time.deltaTime * BulletSpeed, Space.World);

        }
    }

    public void SpawnBullet()
    {
        Vector3 pos = center;
        Instantiate(BulletPre, pos, Quaternion.identity);
    }
}
