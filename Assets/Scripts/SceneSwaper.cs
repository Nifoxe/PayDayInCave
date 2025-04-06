using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwaper : MonoBehaviour
{
    public void SceneCave()
    {
        SceneManager.LoadScene("Cave");
    }
    public void SceneBank()
    {
        SceneManager.LoadScene("Bank");
    }
    public void SceneCafe()
    {
        SceneManager.LoadScene("Cafe");
    }
    public void SceneLaunch()
    {
        if(Save.Money >= 50000)
        {
            Save.Money -= 50000;
            SceneManager.LoadScene("Launch");
        }
    }
    public void SceneBankDeposit()
    {
        if (Save.Money >= 2500)
        {
            Save.Money -= 2500;
            SceneManager.LoadScene("BankDeposit");
        }
    }
    public void SceneGoldInvestement1()
    {
        if (Save.Money >= 10000)
        {
            Save.Money -= 10000;
            SceneManager.LoadScene("GoldInvestement 1");
        }
    }
}
