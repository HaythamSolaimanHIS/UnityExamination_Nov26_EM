using UnityEngine;
using UnityEngine.UI;

public class AudioVolume : MonoBehaviour
{
    public Slider Slider;

    public void SetVolume()

    {
        AudioListener.volume = Slider.value;
    }

}
