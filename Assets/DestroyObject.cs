using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    //���ׂẴJ�����ɉf��Ȃ��Ȃ����Ƃ��ɌĂяo�����֐�
    private void OnBecameInvisible()
    {
        //�Q�[���I�u�W�F�N�g���폜����
        GameObject.Destroy(gameObject);
    }
}
