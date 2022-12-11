//  ゲームに存在するすべてのオブジェクト
public interface IEntity
{
    //  ステータス
    int STR { get; }
    int STA { get; }
    int CON { get; }
    int WIS { get; }
    int INT { get; }
    int CHA { get; }

    //  催眠効果をかける
    void Mesmerize();

    //  HP
    float Health { get; set; }
    int HealthMax { get; }
    int ModifyHealth(int amount);

    //  シールド
    float Shield { get; set; }
    int ShieldMax { get; }
    int ModifyShield(int amount);

}
