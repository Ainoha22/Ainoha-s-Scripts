 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingManager : MonoBehaviour
{
     [SerializeField] private LayerMask Ingredients;
    private ItemSOHolder currentItem;
    public Image customCursor;
    public Slot[] craftingSlots;
    public List<ItemSO> itemList;
    public string[] recipes;
    public ItemSO[] recipeResults;
    [SerializeField] private List<CraftingRecipeSO> craftingRecipeSOList;
    [SerializeField] private BoxCollider placeItemsAreaBoxCollider;
    [SerializeField] private Transform itemSpawnPoint;
    [SerializeField] private Transform vfxSpawnItem;
    private CraftingRecipeSO craftingRecipeSO;

    public Slot resultSlot;
    
    public void Craft(){

        Collider[] colliderArray = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, Quaternion.identity, Ingredients);
                    Debug.Log("Touching");


        List<ItemSO> inputItemList = new List <ItemSO>(craftingRecipeSO.inputItemSOList);
        List<GameObject> consumeItemGameObjectList = new List<GameObject>();

       foreach (Collider collider in colliderArray) {
             if (collider.TryGetComponent(out ItemSOHolder itemSOHolder)){
                if (inputItemList.Contains(itemSOHolder.itemSO)){
                inputItemList.Remove(itemSOHolder.itemSO);
                consumeItemGameObjectList.Add(collider.gameObject);
        Debug.Log(collider);

                }
             }
        }

        if (inputItemList.Count == 0){
            //Transform spawnedItemTransform = Instantiate(craftingRecipeSO.outputItemSO.prefab, itemSpawnPoint.position, itemSpawnPoint.rotation);
            Instantiate(vfxSpawnItem, itemSpawnPoint.position, itemSpawnPoint.rotation);

            foreach (GameObject consumeItemGameObject in consumeItemGameObjectList) {
                Destroy(consumeItemGameObject);
            }
        }
    }

    public void OnMouseDownItem(ItemSOHolder itemSOHolder){
        if (currentItem == null){
            currentItem = itemSOHolder;
        }
    }



}


