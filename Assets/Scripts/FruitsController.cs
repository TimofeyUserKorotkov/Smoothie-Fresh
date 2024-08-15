using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsController : MonoBehaviour
{
    void Update() {
        if (this.GetComponent<Transform>().position.y < -5) {
            Destroy(this.gameObject);
        }
    }
}
