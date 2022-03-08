using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cena3_MenuCtrl : MonoBehaviour
{
    public void BtnReloadScene()
    {
        SceneManager.LoadScene("Problema_3_-_Torricelli");
    }
    public void BtnBackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
