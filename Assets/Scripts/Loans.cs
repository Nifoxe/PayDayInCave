using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Loans : MonoBehaviour
{
    private float PreLoans;
    public Slider slider;
    private TMP_Text LoansPreText;
    public GameObject Loan;
    public GameObject Empty;
    AudioSource audioData;

    void Start()
    {
        LoansPreText = GameObject.Find("LoansPreText").GetComponent<TextMeshProUGUI>();
        audioData = Camera.main.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        PreLoans = slider.value * 1000;
        LoansPreText.text = PreLoans.ToString();
    }
    public void BuyLoans()
    {
        GameObject New = Instantiate(Empty, transform.position, Quaternion.identity);
        Save.Money += (int) PreLoans;
        Loan.SetActive(false);
        slider.value = 1;
        audioData.Play(0);
        if (New.TryGetComponent<CurrentLoan>(out CurrentLoan currentLoan))
        {
            currentLoan.LoansTime = 900;
        }
    }
}
