using System.Collections.Generic;

namespace Places.Models
{
    public class Place
    {
        private string _city;
        private string _state;
        private static List<Place> _instances = new List<Place> {};

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

        public static List<Place> GetAll()
        {
            return _instances;
        }

        public void Save()
        {
            _instances.Add(this);
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

    }
}
