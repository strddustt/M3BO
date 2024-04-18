using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletspeed = 100;
    public static float bulletCooldown = 0; // Use a static variable to be shared among all instances
    public GameObject bulletPrefab; // Drag the bullet prefab into this field in the Unity Inspector

    // Update is called once per frame
    void Update()
    {
        if (bulletCooldown > 0)
        {
            bulletCooldown -= Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0) && bulletCooldown <= 0)
        {
            ShootBullet();
            bulletCooldown = 3; // Reset the cooldown only when you shoot
        }
    }

    void ShootBullet()
    {
        GameObject bulletclone = Instantiate(bulletPrefab, transform.position, Quaternion.identity); // Instantiate bullet without rotation
        Rigidbody rb = bulletclone.GetComponent<Rigidbody>();
        Vector3 direction = (transform.position - bulletclone.transform.position).normalized; // Calculate direction towards player
        rb.velocity = direction * bulletspeed; // Apply velocity towards player
        Destroy(bulletclone, 2);
    }
}
