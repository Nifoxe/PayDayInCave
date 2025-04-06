using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RocketPanel : MonoBehaviour
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
        a = Random.Range(1, 3);
        if (a == 1)
        {
            Save.Money += 150000;
            MissionT.text = "Mission Accomplished";
            YouT.text = "You received 150000 goblings back";
        }
        else if (a == 2)
        {
            MissionT.text = "Mission Failed";
            YouT.text = "You received 0 goblings back";
        }
        ActiveThings.SetActive(true);
    }
}
