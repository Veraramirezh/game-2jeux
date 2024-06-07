using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public int value; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2d(Collider2D other)
    {
        Debug.Log("Inside on trigger enter...");
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this);
            AppleCounter.instance.IncreaseApples(value);
        
        }
    }
}
