using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCraft : MonoBehaviour
{
    [SerializeField] Transform potionCamera;
    private bool startCraft;
    private float startPosX;
    private float startPosY;

    void Start()
    {
        startCraft = false;
    }

    void Update()
    {

    }


    // Update is called once per frame
     private void OnMouseDown() {


        if (Input.GetMouseButtonDown(0))
        {
            startCraft = true;
            Debug.Log("crafting!");

        }  

}
}
