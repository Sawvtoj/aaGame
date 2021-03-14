using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PinSpeed : MonoBehaviour
{
    public Slider slider;

    public void Awake()
    {
        slider = GameObject.FindWithTag("PSpeed").GetComponent<Slider>();
    }

    public void OnEnable()
    {
        slider.onValueChanged.AddListener(delegate { sliderCallBack(slider); });
    }

    public void sliderCallBack(Slider slider)
    {
        Pin.speed = slider.value;
    }
}
