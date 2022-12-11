/// <summary>
/// ステータスを持たせるインターフェイス
/// </summary>
public interface IStats : IHealth
{
    //  ステータス
    int STR { get; }
    int STA { get; }
    int CON { get; }
    int WIS { get; }
    int INT { get; }
    int CHA { get; }
}
