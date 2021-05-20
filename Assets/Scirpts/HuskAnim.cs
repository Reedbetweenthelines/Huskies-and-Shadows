using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuskAnim : MonoBehaviour
{

    Animator husker;


    // Start is called before the first frame update
    void Start()
    {
        husker = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            husker.SetInteger("Form", 1);
            
            if (Input.GetKey(KeyCode.LeftShift))
            {
                husker.SetInteger("Form", 2);

            }
        }
        else
        {         
            husker.SetInteger("Form", 0);            
        }

        if (Input.GetKey(KeyCode.W))
        {
            husker.SetInteger("Form", 1);

            if (Input.GetKey(KeyCode.A))
            {
                husker.SetInteger("Form", 3);

            }
        }
        else
        {
            husker.SetInteger("Form", 0);
        }


    }
}
