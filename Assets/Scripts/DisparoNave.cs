using Unity.Mathematics;
using UnityEngine;

public class DisparoNave : MonoBehaviour
{
    public GameObject bulletprefab, spawnerBullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet =Instantiate(bulletprefab, spawnerBullet.transform.position, Quaternion.identity);

            Bullet bulletscript =bullet.GetComponent<Bullet>();
            bulletscript.target = transform.right;
        }
        

    }
}
