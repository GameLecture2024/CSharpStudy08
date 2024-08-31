using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft
{
    // Is - A 
    // Has - A

    // SCV 가 UnAttack / AttackTerranUnit인가요?
    // interface

    class TerranUnit
    {

    }

    internal class SCV : TerranUnit
    {
        int HP;
        int AttackPower;
        int moveSpeed;
        int Defence;
        int type;         // 1번 소형, 2번 중형 , 3번 대형
    }
}
