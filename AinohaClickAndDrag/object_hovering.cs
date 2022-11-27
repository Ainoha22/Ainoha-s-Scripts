using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class object_hovering : MonoBehaviour
{
    public GameObject cube;

    void OnMouseOver()
    {
        Debug.Log("Over");
         if (Input.GetMouseButton(0)){
            Instantiate(cube);
            //Destroy (gameObject);        
        }
    }
}
