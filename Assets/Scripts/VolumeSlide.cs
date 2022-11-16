using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlide : MonoBehaviour
{
    [SerializeField]
    Slider slider;
    [SerializeField]
    TextMeshProUGUI volumeText; 
    void Update()
    {
        volumeText.text = ((int)(slider.value * 100)).ToString();
    }
}
