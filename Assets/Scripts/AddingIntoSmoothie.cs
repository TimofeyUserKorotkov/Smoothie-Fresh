using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AddingIntoSmothie : MonoBehaviour
{
    public GameObject[] spawners;
    public int addedFruits = 0;
    public int mistakes = 0;

    [SerializeField] Image[] smoothieLayers;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Food" && addedFruits < 20) {
            smoothieLayers[addedFruits].color = collision.gameObject.GetComponent<FruitsController>().selfColor;
            Destroy(collision.gameObject);
            addedFruits += 1;
            Debug.Log(addedFruits);
        }
        if (addedFruits > 19) {
            for (int i = 0; i < spawners.Length; i++) {
                spawners[i].GetComponent<Spawners>().spawn = false;
            }
            SceneManager.LoadScene("FinalScene");
            // LoadDelayedScene();
        }
    }
    // IEnumerator LoadDelayedScene() {
    //     Debug.Log("Started");
    //     yield return new WaitForSeconds(0.5f);
    //     SceneManager.LoadScene("FinalScene");
    // }
}
