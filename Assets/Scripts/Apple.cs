using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
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
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject)
            AppleCounter.instance.IncreaseApples(value);
        
        }
    }
}
