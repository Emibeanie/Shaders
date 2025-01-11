using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToggleHandler : MonoBehaviour
{
    public Material toonMat;
    public Toggle toggle;
    void Start()
    {
        toggle.onValueChanged.AddListener(value => toonMat.SetFloat("_EnableBlinnPhong", value ? 1f : 0f));
    }
}
