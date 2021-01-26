using System;
using System.Collections.Generic;
using System.Text;

namespace IvoUppgift3.Enemies
{
    interface IEnemy
    {

        bool isDead();

        int HealthPoints(int playerLevel);

        int attack(int level);

        int getHp();

        void takeDamage(int damage);
    }
}
