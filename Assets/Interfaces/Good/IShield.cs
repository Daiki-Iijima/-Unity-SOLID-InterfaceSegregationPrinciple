/// <summary>
/// シールドを持たせるインターフェイス
/// </summary>
public interface IShield
{
    int ShieldMax { get; }
    float Shield { get; set; }
    int ModifyShield(int amount);
}
