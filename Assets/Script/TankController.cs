using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : Damabable
{
    public float moventSpeed = 5f;
    public Animator animator;
    public float maxPosition = 8f;
    public Bullet bulletPrefab;
    public Transform bulletOrigin;
    public float bulletSpeed = 5f;
    public float shootRate = 2f;
    public List<DamagableType> canHit;
    void Update()
    {
        Movement();
        Shoot();
    }

    private void Movement(){
        float direction = Input.GetAxisRaw("Horizontal");
        if((direction > 0 && transform.position.x < maxPosition) || (direction < 0 && transform.position.x > -maxPosition))
        {
        transform.position += Vector3.right * direction * moventSpeed * Time.deltaTime;
        }
        animator.SetFloat("Direction", direction);
    } 

    private void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Bullet bullet = Instantiate(bulletPrefab);
            bullet.Setup(bulletOrigin.position, bulletSpeed, Vector3.up, canHit);
        }
    }
}
