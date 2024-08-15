using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    public bool spawn = true;
    [SerializeField] GameObject[] fruitsPrefs;
    public float spawnDelay = 0.5f;
    public float minPosX;
    public float maxPosX;
    public float minPosY;
    public float maxPosY;
    public GameObject mainCanvas;
    void Start()
    {
        StartCoroutine(FruitsSpawn());
    }

    IEnumerator FruitsSpawn() {
        while (spawn) {
            var randPosX = Random.Range(minPosX, maxPosX);
            var randPosY = Random.Range(minPosY, maxPosY);
            var newFruitPosition = new Vector2(randPosX, randPosY);
            // GameObject newFruitObject = Instantiate(fruitsPrefs[Random.Range(0, fruitsPrefs.Length)],
            // newFruitPosition, Quaternion.identity);
            GameObject newFruitObject = Instantiate(fruitsPrefs[Random.Range(0, fruitsPrefs.Length)]);
            newFruitObject.GetComponent<Transform>().position = newFruitPosition;
            newFruitObject.GetComponent<Transform>().SetParent(mainCanvas.GetComponent<RectTransform>());
            yield return new WaitForSeconds(spawnDelay);
        }
    }

}
