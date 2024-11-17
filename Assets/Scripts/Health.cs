using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public int MaxHealth = 100;

    int currentHealth;

    public Image bar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Takedamage(int damage)
    {
        currentHealth -= damage;
        bar.transform.localScale = new Vector3((float)currentHealth / MaxHealth / 1, 1);
    }
}
