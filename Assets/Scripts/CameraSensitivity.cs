using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSensitivity : MonoBehaviour
{
    // Start is called before the first frame update
    public CinemachineFreeLook cineCam;
    private void Start()
    {
        float sens = PlayerPrefs.GetFloat("Sensitivity");
        cineCam.m_XAxis.m_MaxSpeed = 1200 * sens; 
        cineCam.m_YAxis.m_MaxSpeed = sens * 16;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
