using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cena2_MenuCtrl : MonoBehaviour
{
    public void BtnReloadScene()
    {
        SceneManager.LoadScene("Problema_2_-_MUV");
    }
    public void BtnBackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}