using UnityEngine;

public class Grabber : MonoBehaviour
{
    private GameObject selectedObject;
    [SerializeField] 
    private Camera cameraPotions;
    
    // Update is called once per frame
    private void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if(selectedObject == null){
                RaycastHit hit = CastRay();

                if(hit.collider != null){
                    if(!hit.collider.CompareTag("drag")){
                        return;
                    }

                    selectedObject = hit.collider.gameObject;
                    Cursor.visible = false;
                }

            } else {
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraPotions.WorldToScreenPoint(selectedObject.transform.position).z);
            Vector3 worldPosition = cameraPotions.ScreenToWorldPoint(position);
            selectedObject.transform.position = new Vector3(worldPosition.x, 0f, worldPosition.z);

            selectedObject = null;
            Cursor.visible = true;
            }

        }
        if(selectedObject != null){
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraPotions.WorldToScreenPoint(selectedObject.transform.position).z);
            Vector3 worldPosition = cameraPotions.ScreenToWorldPoint(position);
            selectedObject.transform.position = new Vector3(worldPosition.x, 3f, worldPosition.z);
        }
        
    }

    private RaycastHit CastRay()
    {
        Vector3 screenMousePosFar = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            cameraPotions.farClipPlane);
        Vector3 screenMousePosNear = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            cameraPotions.nearClipPlane);
        Vector3 worldMousePosFar = cameraPotions.ScreenToWorldPoint(screenMousePosFar);
        Vector3 worldMousePosNear = cameraPotions.ScreenToWorldPoint(screenMousePosNear);
        RaycastHit hit;
        Physics.Raycast(worldMousePosNear, worldMousePosFar - worldMousePosNear, out hit);

        return hit;
        
    }
}
