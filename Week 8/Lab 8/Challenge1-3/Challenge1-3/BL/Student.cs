namespace Challenge1.BL
{
    internal class Student :Person
    {
        private string Program;
        private int Year;
        private double Fee;
        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }
        public string getProgram()
        {
            return Program;
        }
        public void setProgram(string program)
        {
            this.Program = program;
        }
        public int getYear()
        {
            return Year;
        }
        public void setYear(int year)
        {
            this.Year = year;
        }
        public double getFee()
        {
            return Fee;
        }
        public void setFee(int fee)
        {
            this.Fee = fee;
        }
    }
}
