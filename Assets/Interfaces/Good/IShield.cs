/// <summary>
/// �V�[���h����������C���^�[�t�F�C�X
/// </summary>
public interface IShield
{
    int ShieldMax { get; }
    float Shield { get; set; }
    int ModifyShield(int amount);
}
