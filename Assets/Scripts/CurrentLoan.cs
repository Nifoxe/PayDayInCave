using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLoan : MonoBehaviour
{
    public int LoansTime;

    private void Start()
    {
        StartCoroutine(Countdown());
    }
    void Update()
    {
        if(LoansTime <= 0)
        {
            Destroy(gameObject);
        }
    }
    IEnumerator Countdown()
    { 
        while(true)
        {
            LoansTime--;
            yield return new WaitForSeconds(1);
        }
    }
}
