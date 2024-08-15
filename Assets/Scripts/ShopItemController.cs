using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopItemController : MonoBehaviour
{
    [SerializeField] Image itemImage;
    [SerializeField] TMP_Text itemText;
    [SerializeField] TMP_Text itemPrice;

    public void SetPosition(Vector2 position) {
        GetComponent<RectTransform>().anchoredPosition += position;
    }

    public void SetImage(Sprite sprite) {
        itemImage.sprite = sprite;
    }

    public void SetName(string name) {
        itemText.text = name;
    }

    public void SetPrice(int price) {
        itemPrice.text = price.ToString();
    }
}
