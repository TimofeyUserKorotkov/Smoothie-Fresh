using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopScene : MonoBehaviour
{
    public void LoadShop() {
        SceneManager.LoadScene("ShopScene");
    }

    public void LoadMenu() {
        SceneManager.LoadScene("MenuScene");
    }
}
