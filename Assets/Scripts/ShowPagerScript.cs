using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPagerScript : MonoBehaviour
{
    public TimerScript timer_script;
    // Start is called before the first frame update
    void Start()
    {
        timer_script = GameObject.FindGameObjectWithTag("TimerObject").GetComponent<TimerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        

        Debug.Log("ShowPager is triggered");
        if (other.gameObject.tag == "Player")
        {
            timer_script.addTime(5.0f);
            Destroy(this.gameObject);
        }
    }
}
