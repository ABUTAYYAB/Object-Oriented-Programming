namespace Task3.Bl
{
    internal class Stats
    {
        public Stats(string SkillName, float Damage, float penetration, float heal, float Cost, string description)
        {
            this.SkillName = SkillName;
            this.Damage = Damage;
            this.penetration = penetration;
            this.heal = heal;
            this.Cost = Cost;
            this.description = description;
        }
        public Stats()
        {

        }
        public string SkillName;
        public float Damage;
        public string description;
        public float penetration;
        public float Cost;
        public float heal;
    }
}
