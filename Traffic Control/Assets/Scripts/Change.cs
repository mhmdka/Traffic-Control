using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change {

    private int changeType;

    public int ChangeType
    {
        get
        {
            return changeType;
        }

        set
        {
            changeType = value;
        }
    }

    public Change(int changeType)
    {
        ChangeType = changeType;

    }
}
