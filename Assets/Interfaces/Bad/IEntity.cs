//  �Q�[���ɑ��݂��邷�ׂẴI�u�W�F�N�g
//  �_���ȗ�
public interface IEntity
{
    //  �X�e�[�^�X
    int STR { get; }
    int STA { get; }
    int CON { get; }
    int WIS { get; }
    int INT { get; }
    int CHA { get; }

    //  �������ʂ�������
    void Mesmerize();

    //  HP
    float Health { get; set; }
    int HealthMax { get; }
    int ModifyHealth(int amount);

    //  �V�[���h
    float Shield { get; set; }
    int ShieldMax { get; }
    int ModifyShield(int amount);

}
