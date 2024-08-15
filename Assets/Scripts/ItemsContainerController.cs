using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsContainerController : MonoBehaviour
{
    public Camera mainCam;
    public bool mouseButtonPressed = false;
    public Vector2 offset;

    // void OnMouseDown() {
    //     mouseButtonPressed = true;
    //     offset = (Vector2)mainCam.ScreenToWorldPoint(Input.mousePosition) - (Vector2)this.GetComponent<RectTransform>().transform.position;
    // }

    // void OnMouseUp() {
    //     mouseButtonPressed = false;
    // }

    void Update() {
        if (Input.GetButtonDown("Fire1") && Input.mousePosition.y < 1718) {
            offset = (Vector2)mainCam.ScreenToWorldPoint(Input.mousePosition) - (Vector2)this.GetComponent<RectTransform>().transform.position;
            mouseButtonPressed = true;
        }
        if (Input.GetButtonUp("Fire1") && mouseButtonPressed) mouseButtonPressed = false;
    }

    void FixedUpdate() {
        // Debug.Log(this.GetComponent<RectTransform>().sizeDelta[1]);
        // if (this.GetComponent<RectTransform>().position.y < -5) {
        //     this.GetComponent<RectTransform>().position = Input.mousePosition;
        // }
        // if (mouseButtonPressed) {
        //     Vector2 newPosition = (Vector2)mainCam.ScreenToWorldPoint(Input.mousePosition) - offset;
        //     Vector2 itemPosition = this.GetComponent<RectTransform>().position;
        //     // this.GetComponent<Rigidbody2D>().MovePosition(new Vector2(this.GetComponent<RectTransform>().position.x, newPosition.y));
            
        //     var height = this.GetComponent<RectTransform>().sizeDelta[1] / 2;
        //     if (newPosition.y + height <= 1718 && newPosition.y - height >= 0) {
        //         itemPosition = (Vector2)mainCam.ScreenToWorldPoint(new Vector2(itemPosition.x, newPosition.y));
        //     } else if (newPosition.y + height > 1718) {
        //         itemPosition = (Vector2)mainCam.ScreenToWorldPoint(new Vector2(itemPosition.x, 1718));
        //         Debug.Log(0);
        //     } else if (newPosition.y + height < 0) {
        //         itemPosition = (Vector2)mainCam.ScreenToWorldPoint(new Vector2(itemPosition.x, 0f));
        //         Debug.Log(1);
        //     }
        //     Debug.Log(Input.mousePosition);
        //     Debug.Log(newPosition.x);
        //     this.GetComponent<RectTransform>().position = new Vector2(this.GetComponent<RectTransform>().position.x, itemPosition.y);
        //     // this.GetComponent<RectTransform>().position = new Vector2(this.GetComponent<RectTransform>().position.x, newPosition.y);
        // }
    }
}

