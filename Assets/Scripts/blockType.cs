using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockType : MonoBehaviour {

    public enum blocktype {attack, heal, magic};

    public blocktype thisType;

    public blocktype getType()
    {
        return thisType;
    }


}
