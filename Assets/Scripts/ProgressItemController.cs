using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressItemController : MonoBehaviour
{
    [SerializeField] Image itemImage;
    // [SerializeField] GameObject Button;
    // [SerializeField] TMP_Text itemText;

    [SerializeField] Image footer;
    [SerializeField] Image content;

    public Image filler;

    public void SetPosition(Vector2 position) {
        GetComponent<RectTransform>().anchoredPosition += position;
    }

    public void SetImage(Sprite sprite) {
        itemImage.sprite = sprite;
    }

    public void Switch() {
        // footer = this.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
        // content = this.gameObject.transform.GetChild(1).gameObject.GetComponent<Image>();

        content.color = new Color32(171, 255, 134, 255);
        footer.color = new Color32(171, 255, 134, 255);
    }

    // public void SetName(string name) {
    //     itemText.text = name;
    // }
}
