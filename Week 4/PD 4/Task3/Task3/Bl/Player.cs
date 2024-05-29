using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Bl
{
    internal class Player
    {
        public Player(string name, float health, float energy, float armor)
        {
            this.name = name;
            hp = health;
            this.energy = energy;
            this.armor = armor;
        }
        public Player()
        {

        }

        public float hp;
        public float maxhp = 100;
        public float energy;
        public float maxenergy = 200;
        public float armor;
        public string name;
        public Stats SkillState;
        public List<Stats> SkillStatictics = new List<Stats>();

        public void LearnSkill(Stats skillStats)
        {
            SkillState = skillStats;
        }
        public string Attack(Player target)
        {
            string result;

            float effectiveArmor = Math.Max(0, target.armor - SkillState.penetration);

            if (SkillState.Cost > energy)
            {
                return $"{name} attempted to use {SkillState.SkillName}, but didn't have enough energy!";
            }

            energy -= SkillState.Cost;

            float damage = SkillState.Damage * ((100 - effectiveArmor) / 100);
            target.hp -= damage;

            if (SkillState.heal > 0)
            {
                hp += SkillState.heal;
            }

            result = $"{name} used {SkillState.SkillName}, {SkillState.description}, against {target.name}, doing {damage:F2} damage!";

            if (SkillState.heal > 0)
            {
                result += $" {name} healed for {SkillState.heal} health!";
            }

            if (target.hp <= 0)
            {
                result += $" {target.name} died.";
            }
            else
            {
                double targetHpPercentage = (target.hp / target.maxhp) * 100;
                result += $" {target.name} is at {targetHpPercentage:F2}% health.";
            }

            return result;
        }

    }
}
