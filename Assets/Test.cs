using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;   //�̗�
    private int power = 25; //�U����
    private int mp = 53;    //����(53�ŏ�����)

    //�U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^�����B");
    }

    //�h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂��B");
        //�c���hp�����炷
        this.hp -= damage;
    }

    //���@�p�̊֐�(���W�ۑ�)
    public void Magic(int usedmp)
    {
        //�c���mp���m�F����
        int restmp = this.mp; //���݂�mp
        restmp -= usedmp;     //mp�����̎c��mp

        //mp������Ȃ��ꍇ
        if (restmp < 0)
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
        //mp��5�ȏ�c���Ă���ꍇ
        else
        {
            //�c���mp��5���炷
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
        }
    }
}

public class Test : MonoBehaviour
{

    void Start()
    {
        //�v�f�̌���5�̔z���������
        int[] level = { 10, 1, 30, 50, 15 };

        //�v�f�̒l�����Ԃɕ\��
        Debug.Log("!!�v�f�̒l���������������ɕ\��!!");
 
        //�v�f�̒l��\������
        for (int i = 0; i < level.Length; i++)
        {
            Debug.Log(level[i]);
        }

        //�v�f�̒l���t���ɕ\��
        Debug.Log("!!�v�f�̒l���t�̏��Ԃŕ\��!!");
 
        //�v�f�̒l��\������
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(level[i]);
        }

        //Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        //�U���p�̊֐��Ăяo��
        lastboss.Attack();

        //�h��p�̊֐��Ăяo��
        lastboss.Defence(3);

        //���@�p�̊֐��Ăяo��(10��܂ŁF�U���ł���A11��ȏ�F�U���ł��Ȃ��j
        Debug.Log("!!���@�p�̊֐��Ăяo��!!");

        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic(5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
