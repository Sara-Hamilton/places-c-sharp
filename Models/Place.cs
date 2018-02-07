namespace Places.Models
{
    public class Place
    {
        private string _city;
        private string _state;

        public Place (string city, string state)
        {
            _city = city;
            _state = state;
        }

        public string GetCity()
        {
            return _city;
        }

        public void SetCity(string newCity)
        {
            _city = newCity;
        }

        public string GetState()
        {
            return _state;
        }

        public void SetState(string newState)
        {
            _state = newState;
        }

    }
}
