using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomInspectorTest : MonoBehaviour
{
    public int count;
    public bool i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPress()
    {
        count += 1;
        i = !i;
    }
}
