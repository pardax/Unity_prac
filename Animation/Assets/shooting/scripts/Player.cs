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

    //플레이어 체력 추가
    //골드가 화면바깥으로 나가지 않도록
    //몬스터 추가
    //일시정지 기능 추가

    //플레이어 체력 UI로 표시
    //HP 회복 아이템 추가
    //골드를 오브젝트풀링 으로 관리
    //메테오 추가, 캐릭터의 x축을 일정시간동안 추적, 화면에 보이면(일정 거리) 추적과 알람을 제거 후 메테오 낙하
    //점수 100점 이상이면 미사일 2개씩 발사 (업그레이드)
}
