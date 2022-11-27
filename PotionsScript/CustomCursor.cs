using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        transform.position = Input.mousePosition;
    }

    
    private void Update()
    {
        transform.position = Input.mousePosition;
    }


}
