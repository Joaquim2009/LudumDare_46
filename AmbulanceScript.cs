using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbulanceScript : MonoBehaviour
{
    public int howManyPeople = 1;
    public int peopleInAmbulance = 0;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Crazy")
        {
            Debug.Log("AAAA");
            Destroy(other.gameObject);
            peopleInAmbulance+=1;
            if(howManyPeople <= peopleInAmbulance)
            {
                Debug.Log("NextLevel");
                GetComponent<Animator>().SetTrigger("GoAway");
            }
        }
    }
    public void NextLevel()
    {
        GameManager.NextLevel();
    }
}
