using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RotationSpeed : MonoBehaviour
{
    public Slider slider;

    public void Awake()
    {
        slider = GameObject.FindWithTag("RSpeed").GetComponent<Slider>();
    }

    public void OnEnable()
    {
        slider.onValueChanged.AddListener(delegate { sliderCallBack(slider); });
    }

    public void sliderCallBack(Slider slider)
    {
        Rotator.speed = slider.value;
    }
}
