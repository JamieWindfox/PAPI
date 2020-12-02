namespace PAPI.Settings
{
    public class Player
    {
        public string m_name { get; private set; }

        public Player(string name)
        {
            m_name = name;
        }

        public Player() : this("NOT VALID") { }

        public void SetName(string name)
        {
            m_name = name;
        }
    }
}