/// <summary>
/// HP����������Interface
/// HP�����������Ă��ď�Ԃ������Ă��Ȃ��I�u�W�F�N�g������̂ŕ������Ă���
/// </summary>
public interface IHealth
{
    int HealthMax { get; }
    float Health { get; set; }
    int ModifyHealth(int amount);
}
