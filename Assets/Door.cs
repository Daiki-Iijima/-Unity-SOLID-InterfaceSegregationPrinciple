using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// HP(耐久値)を持ったドア
/// いい例
/// </summary>
//public class Door : IEntity
//{
//    public int STR => throw new System.NotImplementedException();
//
//    public int STA => throw new System.NotImplementedException();
//
//    public int CON => throw new System.NotImplementedException();
//
//    public int WIS => throw new System.NotImplementedException();
//
//    public int INT => throw new System.NotImplementedException();
//
//    public int CHA => throw new System.NotImplementedException();
//
//    public float Shield { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
//
//    public int ShieldMax => throw new System.NotImplementedException();
//
//    public void Mesmerize() {
//        throw new System.NotImplementedException();
//    }
//
//    public int ModifyShield(int amount) {
//        throw new System.NotImplementedException();
//    }
//}

/// <summary>
/// HP(耐久値)を持ったドア
/// いい例
/// </summary>
public class Door : IHealth
{
    public int HealthMax => throw new System.NotImplementedException();

    public float Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public int ModifyHealth(int amount) {
        throw new System.NotImplementedException();
    }
}
