using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassController : MonoBehaviour
{
    public GameObject glass;
    public bool mouseButtonPressed = false;
    public Vector2 offset;
    public Camera mainCam;

    void OnMouseDown() {
        mouseButtonPressed = true;
        glass.GetComponent<Rigidbody2D>().gravityScale = 0;
        offset = (Vector2)mainCam.ScreenToWorldPoint(Input.mousePosition) - (Vector2)glass.GetComponent<Transform>().transform.position;
    }

    void FixedUpdate() {
        if (this.GetComponent<RectTransform>().position.y < -5) {
            this.GetComponent<RectTransform>().position = Input.mousePosition;
        }

        if (mouseButtonPressed) {
            Vector2 newPosition = (Vector2)mainCam.ScreenToWorldPoint(Input.mousePosition) - offset;
            glass.GetComponent<Rigidbody2D>().MovePosition(newPosition);
        }
    }

    void Update() {
        if (Input.GetButtonUp("Fire1")) {
            glass.GetComponent<Rigidbody2D>().gravityScale = 5;
            mouseButtonPressed = false;
        }
    }

    public void StartDrag() {
        if (Input.GetButtonDown("Fire1")) mouseButtonPressed = true;
    }
}
