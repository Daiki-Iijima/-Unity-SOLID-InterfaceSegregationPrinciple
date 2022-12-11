/// <summary>
/// HPを持たせるInterface
/// HPだけを持っていて状態を持っていないオブジェクトもいるので分離している
/// </summary>
public interface IHealth
{
    int HealthMax { get; }
    float Health { get; set; }
    int ModifyHealth(int amount);
}
