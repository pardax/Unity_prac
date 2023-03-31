using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    int hp = 2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal")) {
            float h = Input.GetAxisRaw("Horizontal");

            transform.Translate(Vector3.right * h * 3f * Time.deltaTime);

            Vector3 myPos = transform.position;
            
            // if value are less then min, return min
            // if value are bigger then max, return max
            myPos.x = Mathf.Clamp(transform.position.x, -2f, 2);
            transform.position = myPos;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            if(hp > 0)
            {
                hp--;
                Debug.Log("hp : " + hp);
            }
            else
            {
                SceneManager.LoadScene("Result");
            }
        }
    }

    //�÷��̾� ü�� �߰�
    //��尡 ȭ��ٱ����� ������ �ʵ���
    //���� �߰�
    //�Ͻ����� ��� �߰�

    //�÷��̾� ü�� UI�� ǥ��
    //HP ȸ�� ������ �߰�
    //��带 ������ƮǮ�� ���� ����
    //���׿� �߰�, ĳ������ x���� �����ð����� ����, ȭ�鿡 ���̸�(���� �Ÿ�) ������ �˶��� ���� �� ���׿� ����
    //���� 100�� �̻��̸� �̻��� 2���� �߻� (���׷��̵�)
}
