using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AppleCounter : MonoBehaviour
{
    public static AppleCounter instance;
    public TMP_Text appleText;
    public int currentApples = 0; 

    void Awake()
    {
        instance = this;
        
    }


   
    // Start is called before the first frame update
    void Start()
    {
        appleText.text = currentApples.ToString();
    }

    // Update is called once per frame
    public void IncreaseApples(int v)
    {
       currentApples += v;
       appleText.text = currentApples.ToString();
    }
}
