using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AttributeId
{
    Damage,
    Armor,
    Health,
    AtkSpeed,
    AtkRange,
    MoveSpeed,
}

[Serializable]
public class Attribute
{
    [SerializeField]
    private AttributeId attrId;
    [SerializeField]
    private int value;

    public AttributeId AttrId
    {
        get { return attrId; }
        set { attrId = value; }
    }

    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
}
