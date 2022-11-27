 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class place_object : MonoBehaviour
{ 

    RaycastHit hit;
   // Vector3 movePoint;
    public GameObject prefab;


    void Start(){
        
        /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, 50000.0f)){
            transform.position = hit.point;
        }
        */
    }

    void Update(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        LayerMask mask = LayerMask.GetMask("Obstacle");
        
        if(Physics.Raycast(ray, out hit, 50000.0f)){
            transform.position = hit.point;
        }

        if (Input.GetMouseButton(0)){
            

            //LayerMask mask = LayerMask.GetMask("Obstacle");

            if (Physics.SphereCast(ray, 1/10, 50000.0f, mask)){
                Destroy(gameObject);
                //ingredient = prefab;
                //Debug.Log("Destroyed " + prefab);
                //FindObjectOfType<AudioManager>().Play("Error");
            }
            // else{
                
            //     //Instantiate(prefab, transform.position,transform.rotation);
            //     //Destroy(gameObject);
            // }
                 

    }
   
    
}
}