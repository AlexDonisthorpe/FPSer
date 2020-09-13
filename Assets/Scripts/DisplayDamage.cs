using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] GameObject imageObject;
    Color imageColor;

    [SerializeField] float opacityDecay = 0.1f;
    bool isActive = false;

    private void Start()
    {
        imageColor = imageObject.GetComponent<Image>().color;
        imageObject.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
    }

    public void HandleHitFX()
    {
        imageObject.GetComponent<Image>().color = imageColor;
    }

    private void Update()
    {
        imageObject.GetComponent<Image>().color -= new Color(0, 0, 0, opacityDecay) * Time.deltaTime;
    }
}
