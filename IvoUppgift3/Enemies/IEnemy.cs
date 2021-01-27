using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies
{
    interface IEnemy
    {

        bool IsDead();

        int HealthPoints(int playerLevel);

        int Attack(int level);

        int GetHp();

        void TakeDamage(int damage);
    }
}
