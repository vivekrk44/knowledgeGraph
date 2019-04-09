using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teamData
{
    public string category;
    public int teamNo;
    public string teamName;
    public string feasablilityScore;
    public string somethingA;
    public string somethingB;
    public string thisA;
    public string thisB;
    public string thatA;
    public string thatB;
};

public class data_reader : MonoBehaviour
{
    public List <teamData> dat;
    public int state = 0;
    // Start is called before the first frame update
    void Start()
    {
        getData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void getData()
    {
        for (int i=0; i<10; i++)
        {
            teamData tmp = new teamData();
            tmp.teamNo = i;
            tmp.teamName = i.ToString();
            tmp.feasablilityScore = (i + 4).ToString();

            tmp.somethingA = "somethingA: " + i.ToString();
            tmp.somethingB = "somethingB: " + i.ToString();

            tmp.thatA = "thatA: " + i.ToString();
            tmp.thatB = "thatB: " + i.ToString();

            tmp.thisA = "thisA: " + i.ToString();
            tmp.thisB = "thisB: " + i.ToString();

            dat.Add(tmp);
        }
    }
}
