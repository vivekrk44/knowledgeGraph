using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class data_reader : MonoBehaviour
{
    public int state = 0;
    public Sheet1 da;
    public List<int> batteryMulti;
    public List<int> batteryFixed;
    public List<int> hydroMulti;
    public List<int> hydroFixed;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<da.dataArray.Length; i++)
        {
            if(da.dataArray[i].Category == "Battery powered multi-rotor")
            {
                batteryMulti.Add(i);
            }
            if(da.dataArray[i].Category == "Battery powered fixed-wing")
            {
                batteryFixed.Add(i);
            }
            if(da.dataArray[i].Category == "Hydrocarbon/Hybrid powered multi-rotor")
            {
                hydroMulti.Add(i);
            }
            if(da.dataArray[i].Category == "Hydrocarbon/hybrid powered fixed-wing")
            {
                hydroFixed.Add(i);
            }
        }

        Debug.Log("Got " + batteryMulti.Count.ToString() + " battery multirotor");
        Debug.Log("Got " + batteryFixed.Count.ToString() + " battery fixed");
        Debug.Log("Got " + hydroMulti.Count.ToString() + " hydro multirotor");
        Debug.Log("Got " + hydroFixed.Count .ToString() + " hydro fixed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
