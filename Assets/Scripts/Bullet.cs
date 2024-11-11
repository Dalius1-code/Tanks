using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Bullet : MonoBehaviour
{
    public float speed = 15f;
    public float lifetime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
