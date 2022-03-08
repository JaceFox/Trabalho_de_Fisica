using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cena0_MENU : MonoBehaviour
{
    public void BtnOpenMRU()
    {
        SceneManager.LoadScene("Problema_1_-_MRU");
    }

    public void BtnOpenMUV()
    {
        SceneManager.LoadScene("Problema_2_-_MUV");
    }

    public void BtnOpenTorri()
    {
        SceneManager.LoadScene("Problema_3_-_Torricelli");
    }
}