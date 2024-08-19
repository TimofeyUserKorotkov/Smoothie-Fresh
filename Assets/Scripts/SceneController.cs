using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadMenu() {
        SceneManager.LoadScene("MenuScene");
    }

    public void LoadGame() {
        SceneManager.LoadScene("GameScene");
    }

    public void LoadShop() {
        SceneManager.LoadScene("ShopScene");
    }

    public void LoadProgress() {
        SceneManager.LoadScene("LvlScene");
    }
}
