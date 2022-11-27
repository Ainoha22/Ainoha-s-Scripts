using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerPickUpDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    //[SerializeField] private Transform mainCamera;
    [SerializeField] Transform objectGrabPointTransform;
    [SerializeField] private LayerMask pickUpLayerMask;
    // Update is called once per frame
    //private ObjectGrabbable objectGrabbable;

    //private Collider objectCollider;

    // void Start(){
    //     objectCollider = GetComponent<Collider>();
    // }
    private void Update()
    {//---------------------------------------------------------------------------------------------
    //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
    //     if (Physics.SphereCast(ray, 30f, out RaycastHit raycastHit)){
    //         Debug.Log(raycastHit.collider.name);
    //     }

    //    if   (Input.GetKey(KeyCode.Mouse0)&& raycastHit.collider.name == "Cube (2)" ){
    //     if (Physics.Raycast(ray, out RaycastHit raycastHit1) ){
    //         transform.position = raycastHit1.point; // object being grabeed change the transform.position to GameObject.transform.position for list of objects
            
    //    }}//}

        
//---------------------------------------------------------------- OMAR EDIT
       // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //if (Physics.Raycast(ray, out RaycastHit raycastHit1)){
        //    transform.position = raycastHit1.point;
       // }


//----------------------------------------------------------------
       if (Input.GetMouseButtonDown(0)){
            //if (objectGrabbable == null){
            float pickUpDistance = 50f;
            if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpDistance, pickUpLayerMask))
        {
            //Debug.DrawRay(Camera.main.transform.position, objectGrabbable.transform.position, Color.green);

            if (raycastHit.transform.TryGetComponent(out ObjectGrabbable objectGrabbable))
        {
             Debug.DrawRay(Camera.main.transform.position, objectGrabbable.transform.position, Color.green);
            objectGrabbable.Grab(objectGrabPointTransform);
            Debug.Log(objectGrabbable);
        }
        }
        // } else {
        //     objectGrabbable.Drop();
        //     objectGrabbable = null;
        
    }
} 
//Debug.DrawRay(Camera.main.transform.position, raycastHit1.point, Color.green);
//Debug.Log(objectGrabbable);
}

