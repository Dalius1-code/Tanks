using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool Player1  = true;
    public bool Player2 = false;
    [Header("Movement")]

    public float speed = 10f;

    [Header("Shooting")]
    public GameObject bulletPrefab;
    public Transform bulletSpawn;


    public float fireRate = 0.5f;
    private object other;

    [Header("Health")]
    public Health health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var input = new Vector3();
        if(Player1)
        {
            input.x = Input.GetAxis("HorizontalKeys");
            input.z = Input.GetAxis("VerticalKeys");
        }
        if(Player2)
        {
            input.x = Input.GetAxis("HorizontalArrows");
            input.z = Input.GetAxis("VerticalArrows");
        }


        transform.position += input * speed * Time.deltaTime;
        if(input != Vector3.zero)
        {
            transform.forward = input;
        }
        
    }
    void shoot()
    {
        Instantiate(bulletPrefab, bulletSpawn.position, transform.rotation);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (other.gameObject.Compare("Bullet")
        {
            Health.Takedamage(Bullet.damage);
        }
    }
}
