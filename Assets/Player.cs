using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// シールド値を持ったプレイヤー
/// ダメな例(実装敵には問題ないが、インターフェイスが大きすぎてほかのクラスへの影響が出ている)
/// </summary>
//public class Player : IEntity
//{
//    public int STR => throw new System.NotImplementedException();

//    public int STA => throw new System.NotImplementedException();

//    public int CON => throw new System.NotImplementedException();

//    public int WIS => throw new System.NotImplementedException();

//    public int INT => throw new System.NotImplementedException();

//    public int CHA => throw new System.NotImplementedException();

//    public float Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

//    public int HealthMax => throw new System.NotImplementedException();

//    public float Shield { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

//    public int ShieldMax => throw new System.NotImplementedException();

//    public void Mesmerize() {
//        throw new System.NotImplementedException();
//    }

//    public int ModifyHealth(int amount) {
//        throw new System.NotImplementedException();
//    }

//    public int ModifyShield(int amount) {
//        throw new System.NotImplementedException();
//    }
//}

/// <summary>
/// シールド値を持ったプレイヤー
/// いい例
/// </summary>
public class Player : IStats, IShield
{
    public int STR => throw new System.NotImplementedException();

    public int STA => throw new System.NotImplementedException();

    public int CON => throw new System.NotImplementedException();

    public int WIS => throw new System.NotImplementedException();

    public int INT => throw new System.NotImplementedException();

    public int CHA => throw new System.NotImplementedException();

    public int HealthMax => throw new System.NotImplementedException();

    public float Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public int ShieldMax => throw new System.NotImplementedException();

    public float Shield { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public int ModifyHealth(int amount) {
        throw new System.NotImplementedException();
    }

    public int ModifyShield(int amount) {
        throw new System.NotImplementedException();
    }
}
