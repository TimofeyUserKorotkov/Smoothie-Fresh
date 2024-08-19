using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsController : MonoBehaviour
{
    public Color32 selfColor;
    
    void Update() {
        if (this.GetComponent<Transform>().position.y < -5) {
            Destroy(this.gameObject);
        }
    }
}
