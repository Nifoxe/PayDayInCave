using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BankPanel : MonoBehaviour
{   
    public Image panelImage;
    public GameObject ActiveThings;
    public GameObject Mission;
    public GameObject You;
    private TMP_Text MissionT;
    private TMP_Text YouT;
    int a = 0;
    void Start()
    {
        MissionT = Mission.GetComponent<TextMeshProUGUI>(); ;
        YouT = You.GetComponent<TextMeshProUGUI>();
        Invoke("StartChangingAlpha", 10f);
        Invoke("Show", 13f);
    }

    void StartChangingAlpha()
    {
        StartCoroutine(ChangeAlphaOverTime());
    }

    IEnumerator ChangeAlphaOverTime()
    {
        while (panelImage.color.a < 1f) // Keep increasing until fully visible
        {
            Color color = panelImage.color;
            color.a = Mathf.Clamp01(color.a + 0.01f * Time.deltaTime * 60);
            panelImage.color = color;
            yield return null;
        }
    }
    void Show()
    {
        Save.Money += 5000;
        MissionT.text = "You have withdrawn funds";
        YouT.text = "You received 5000 goblings back";
        ActiveThings.SetActive(true);
    }
}
