using UnityEngine;
using UnityEngine.UI;

public class Settingsslider : MonoBehaviour
{
    public GameObject Slider;

    public void Settingslider()

    {
        Slider.SetActive(!Slider.activeSelf);
    }
}
