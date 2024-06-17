using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [Header("--- Projectile Settings ---")]
    public Transform projectileSpawn;
    public GameObject projectilePrefab;
    public int projectileSpeed = 20;
    public int projectileLifeTime = 2;


    void Start()
    {
        
    }

    
    void Update()
    {
        // Detect LMB input
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }

    void Shoot()
    {
        // Instantiate the projectile
        GameObject proj = Instantiate(projectilePrefab, projectileSpawn.position, projectileSpawn.rotation);
        // Set projectile's velocity (make sure it travels forward relative to facing direction)
        proj.GetComponent<Rigidbody>().velocity = projectileSpawn.forward * projectileSpeed;
        // Destroy the projectile after some time
        Destroy(proj, projectileLifeTime);
    }
}
