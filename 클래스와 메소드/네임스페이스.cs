/*
 *  학습 목표 : 이름 공간(name space)에 대한 이해
 *  작성일    : 2024-08-17
 *  작성자    : 김동훈
 */

/*
 *  이름 : 다른 이름을 가짐으로써 구분할 수 있다.
 *  만약에 같은 이름이 중복되면 어떻게 될까?
 *  -> 컴파일 에러가 발생한다.(실행이 안됩니다.)
 *  
 *  다른 비교할 기준이 있으면 두 대상을 구분할 수 있게 됩니다.
 *  같은 이름을 분류하는 이름 공간
 */

/*
 *  2. 네임 스페이스 선언 방법
 *  namespace 이름공간의 이름 {    }  범위를 표현해주는 기호
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 부산
{
   class 밀면
    {
        public int count;
    }
}

namespace 서울
{
    class 밀면
    {
        public int count;
    }
}

// 이름 공간( 커피 브랜드 두개 선언을 해보세요)

namespace 스타벅스
{
    class Coffee
    {
        public string name;
    }
}

namespace 하삼동커피
{
    class Coffee
    {
        public string name;
    }
}

namespace 클래스와_메소드
{
    internal class 네임스페이스
    {
        public void Show()
        {
            Console.WriteLine("Hello World!");

            // 1. 같은 이름이 중복되면 안되는 예시
            int num = 10;
            int num2 = 20;

            부산.밀면 noodle = new 부산.밀면();
            noodle.count = 1;
            Console.WriteLine(noodle.count);
            서울.밀면 noodle2 = new 서울.밀면();
            noodle2.count = 10;
            Console.WriteLine(noodle2.count);

            스타벅스.Coffee coffee = new 스타벅스.Coffee();
            하삼동커피.Coffee coffee2 = new 하삼동커피.Coffee();

        }
    }
}
