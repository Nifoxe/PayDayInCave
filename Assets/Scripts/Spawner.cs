using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coalOre;
    public GameObject ironOre;
    public GameObject goldOre;
    public GameObject rubyOre;
    public GameObject emeraldOre;
    public GameObject diamondOre;
    public GameObject glitchOre;
    private bool isobj;
    void Start()
    {
        StartCoroutine("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawn()
    {
        while(true)
        {
            if(!isobj)
            {
                int time = Random.Range(5, 20);
                int chance = Random.Range(1, 100);
                if (chance > 0 && chance < 45)
                {
                    Instantiate(coalOre, transform.position, Quaternion.identity);
                }
                else if (chance > 45 && chance < 65)
                {
                    Instantiate(ironOre, transform.position, Quaternion.identity);
                }
                else if (chance > 65 && chance < 80)
                {
                    Instantiate(goldOre, transform.position, Quaternion.identity);
                }
                else if (chance > 80 && chance < 93)
                {
                    Instantiate(rubyOre, transform.position, Quaternion.identity);
                }
                else if (chance > 93 && chance < 98)
                {
                    Instantiate(emeraldOre, transform.position, Quaternion.identity);
                }
                else if (chance > 98 && chance <= 100)
                {
                    int wowchance = Random.Range(1, 100);
                    if (wowchance > 0 && chance <= 5)
                    {
                        Instantiate(glitchOre, transform.position, Quaternion.identity);
                    }
                    else if(wowchance > 5)
                    {
                        Instantiate(diamondOre, transform.position, Quaternion.identity);
                    }
                }
                yield return new WaitForSeconds(time);
            }
        }
    }
}
