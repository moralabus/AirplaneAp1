using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AirplaneAp1
{
   

    public class Airplane
    {
        public string Model;  // Модель самолета
        public int Range;  // Дальность полета
        public string Company;  // Авиакомпания
        public decimal FuelConsumption;  // Потребление горючего

        // Статическое поле для розового и голубого
        public static Color BackColor
        {
            get
            {
                // Получаем текущий день недели (от 0 до 6)
                int currentDay = DateTime.Now.DayOfWeek.GetHashCode();

                // Если день четный - цвет розовый, иначе - голубой
                return (currentDay % 2 == 1) ? Color.LightPink : Color.LightBlue;
            }
        }

        // Конструктор с четырьмя параметрами
        public Airplane(string model, int range, string company, decimal fuelConsumption)
        {
            Model = model;
            Range = range;
            Company = company;
            FuelConsumption = fuelConsumption;
        }

        // Конструктор без параметров (использует значения по умолчанию)
        public Airplane()
        {
            Model = "Unknown";
            Range = 0;
            Company = "Unknown";
            FuelConsumption = 0;
        }

        // Конструктор с двумя параметрами
        public Airplane(string model, int range)
        {
            Model = model;
            Range = range;
            Company = "Unknown";
            FuelConsumption = 0;
        }

        public override string ToString()
        {
            return $"Самолет: {Model} ({Company}), Дальность полета: {Range} км, Потребление горючего: {FuelConsumption} л/100км";
        }
    }

    public struct FlightData
    {
        public string DepartureCity;  // Поле для города вылета
        public string ArrivalCity;  // Поле для города прибытия
        public DateTime DepartureTime;  // Поле для времени вылета

        // Конструктор без параметров (использует значения по умолчанию)
        public FlightData()
        {
            DepartureCity = "Unknown";
            ArrivalCity = "Unknown";
            DepartureTime = DateTime.MinValue;
        }

        // Конструктор с параметрами
        public FlightData(string departureCity, string arrivalCity, DateTime departureTime)
        {
            DepartureCity = departureCity;
            ArrivalCity = arrivalCity;
            DepartureTime = departureTime;
        }
    }
}
