using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CraftingRecipeSO")]
public class CraftingRecipeSO : ScriptableObject
{
    public ItemSO output;

    public List<ItemSO> inputItemSOList;
    public ItemSO outputItemSO;
    public ItemSO item_0;
    public ItemSO item_1;
    public ItemSO item_2;
    public ItemSO item_3;


}
