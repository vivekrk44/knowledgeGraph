using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_machine : MonoBehaviour
{
    
    // Start is called before the first frame update
    public Canvas node0;
    public Canvas node1;
    public Canvas node2;
    public Canvas node3;
    public Canvas node4;
    public int state = 0;
    public int sub_state = 0;
    public data_reader d;

    public Button[] buttons;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(state)
        {
            case 0:
                case0UI();
                break;

            case 1:
                case1UI();
                break;

            case 2:
                case2UI();
                break;

            default:
                Debug.Log("Wrong state");
                break;
        }
    }

    public void node1_pressed()
    {
        state = 1;
    }

    public void hydro_fixed_pressed()
    {
        state = 2;
        sub_state = 2;
    }

    public void hydro_multi_pressed()
    {
        state = 2;
        sub_state = 1;
    }

    public void battery_fixed_pressed()
    {
        state = 2;
        sub_state = 3;
    }

    public void battery_multi_pressed()
    {
        state = 2;
        sub_state = 4;
    }

    void case0UI()
    {
        node0.enabled = true;
        node1.enabled = false;
        node2.enabled = false;
        node3.enabled = false;
        node4.enabled = false;
        return;
    }

    void case1UI()
    {
        node0.enabled = false;
        node1.enabled = true;
        node2.enabled = false;
        node3.enabled = false;
        node4.enabled = false;
        return;
    }

    void case2UI()
    {
        node0.enabled = false;
        node1.enabled = false;
        node2.enabled = true;
        node3.enabled = false;
        node4.enabled = false;
        

        
        return;
    }
}
