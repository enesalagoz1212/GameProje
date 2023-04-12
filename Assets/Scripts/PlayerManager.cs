using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float health;
    bool dead = false;
    Transform muzzle;
    public Transform bullet;
    public float bulletSpeed;
    void Start()
    {
        muzzle = transform.GetChild(1);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBullet();
        }
    }
    public void GetDamage(float damage)
    {
        if ((health-damage)>=0)
        {
            health -= damage;
        }
        else
        {
            health = 0;
        }
        AmIDead();
    }
    void AmIDead()
    {
        if (health<=0)
        {
            dead = true;
        }
    }
    void ShootBullet()
    {
        Transform tempBullet;
       tempBullet= Instantiate(bullet,muzzle.position,Quaternion.identity);
        tempBullet.GetComponent<Rigidbody2D>().AddForce(muzzle.forward * bulletSpeed);
        Debug.Log("dswfdnqalwrfdq");
    }
}
