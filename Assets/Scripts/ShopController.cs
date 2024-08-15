using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    [SerializeField] GameObject offerPrefab;
    [SerializeField] RectTransform itemsContainer;
    [SerializeField] Sprite[] fruitIcons;
    [SerializeField] int itemSize;
    [SerializeField] int itemSpacing;

    [SerializeField] int[] itemPrices;
    [SerializeField] string[] itemNames;

    void Start() {
        itemsContainer.sizeDelta = new Vector2(1080, (itemSize + itemSpacing) * fruitIcons.Length);
        itemsContainer.position = new Vector2(itemsContainer.position.x, itemsContainer.position.y + (itemSize + itemSpacing) * fruitIcons.Length / -384);
        for (int i = 0; i < fruitIcons.Length; i++) {
            ShopItemController shopItem = Instantiate(offerPrefab, itemsContainer.transform).GetComponent<ShopItemController>();
            shopItem.SetPosition(Vector2.down * i * (itemSize + itemSpacing));

            shopItem.SetName(itemNames[i]);
            shopItem.SetPrice(itemPrices[i]);
            shopItem.SetImage(fruitIcons[i]);
        }
    }
    void Update()
    {
        
    }
}
