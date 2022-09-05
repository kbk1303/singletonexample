namespace singleton.example
{
    internal class TestSIngleTon
    {
        private static TestSIngleTon? instance = null;
        private TestSIngleTon() { }

        public static TestSIngleTon Instance
        {
            get
            {
                instance ??= new TestSIngleTon();//compound statement ??= same as nullable
                return instance;
            }
        }
    }

}