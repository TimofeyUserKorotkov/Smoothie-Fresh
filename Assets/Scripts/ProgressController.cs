using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProgressController : MonoBehaviour
{
    [SerializeField] GameObject segmentPrefab;
    [SerializeField] RectTransform itemsContainer;
    [SerializeField] Sprite[] itemIcons;
    [SerializeField] int itemSize;

    [SerializeField] GameObject startSegment;
    [SerializeField] GameObject endSegment;

    [Range(0, 900)]
    [SerializeField] int fillAmountFull;

    public ProgressItemController[] allSegments = new ProgressItemController[7];

    void Start() {
        itemsContainer.sizeDelta = new Vector2(itemSize * itemIcons.Length + 1320, 1920);
        itemsContainer.position = new Vector2(itemsContainer.position.x + itemSize * itemIcons.Length, itemsContainer.position.y);

        startSegment.GetComponent<RectTransform>().anchoredPosition -= Vector2.right * (itemsContainer.rect.width / 2 - 330);
        endSegment.GetComponent<RectTransform>().anchoredPosition += Vector2.right * ((itemSize * itemIcons.Length) + 990 - itemsContainer.rect.width / 2);
        for (int i = 0; i < itemIcons.Length; i++) {
            ProgressItemController progressItem = Instantiate(segmentPrefab, itemsContainer.transform).GetComponent<ProgressItemController>();
            progressItem.SetPosition(Vector2.right * ((i * itemSize) - 330 - (itemsContainer.rect.width - itemSize) / 2));

            progressItem.SetImage(itemIcons[i]);
            allSegments[i] = progressItem;
        }
        allSegments[2].Switch();
    }

    void Update() {
        ProgressItemController startSegmentPIC = startSegment.GetComponent<ProgressItemController>();
        ProgressItemController endSegmentPIC = endSegment.GetComponent<ProgressItemController>();
        int fillSegments = (int)Math.Floor(fillAmountFull * 0.01f);
        float fillSegmentsF = (float)Math.Floor(fillAmountFull * 0.01f);
        if (fillSegments > 0 && fillSegments < allSegments.Length + 2) {
            startSegmentPIC.filler.fillAmount = 1f;
            for (int i = 0; i < fillSegments - 1; i++) allSegments[i].filler.fillAmount = 1f;
            if (fillSegments < allSegments.Length + 1) {
                allSegments[fillSegments - 1].filler.fillAmount = fillAmountFull * 0.01f - fillSegmentsF;
                for (int i = 0; i < allSegments.Length; i++) if (i > fillSegments - 1) allSegments[i].filler.fillAmount = 0f;
                endSegmentPIC.filler.fillAmount = 0f;
            }
            else endSegmentPIC.filler.fillAmount = fillAmountFull * 0.01f - fillSegmentsF;
        } else {
            startSegmentPIC.filler.fillAmount = fillAmountFull * 0.01f;
            for (int i = 0; i < allSegments.Length; i++) if (i > fillSegments - 1) allSegments[i].filler.fillAmount = 0f;
            endSegmentPIC.filler.fillAmount = 0f;
        }
    }
}
