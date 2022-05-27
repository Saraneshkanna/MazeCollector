using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivityManager : MonoBehaviour
{
    [SerializeField] Slider sensSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Sensitivity"))
        {
            PlayerPrefs.SetFloat("Sensitivity", 1f);
            Load();
        }
        else
        {
            Load();
        }
    }
    public void sensChange()
    {
        Save();
    }

    private void Load()
    {
        sensSlider.value = PlayerPrefs.GetFloat("Sensitivity");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("Sensitivity", sensSlider.value);
    }
}
