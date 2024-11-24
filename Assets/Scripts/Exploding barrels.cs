using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explodingbarrels : MonoBehaviour
{
    public int Health = 20;
    public float currentHealth;
    public float spawnRadius = 5f;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeExDamage(int explosicdamage)
    {
        currentHealth -= explosicdamage;
        if (currentHealth < = 0)
        {

        }
    }
}
