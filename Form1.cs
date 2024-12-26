using AirplaneAp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AirplaneAp1
{
    public partial class Form1 : Form
    {
        private List<Airplane> airplanes = new List<Airplane>();


        public Form1()
        {
            InitializeComponent();
            buttonAddAirplane.Click += buttonAddAirplane_Click;
            buttonSortByFuelConsumption.Click += buttonSortByFuelConsumption_Click;
            // Задаем цвет формы в конструкторе, чтобы он менялся каждый раз при запуске
            this.BackColor = Airplane.BackColor;
        }


        private void buttonAddAirplane_Click(object sender, EventArgs e)
        {
            // Получаем данные с формы
            string model = comboBoxModel.SelectedItem?.ToString();
            int range = (int)numericUpDownRange.Value;
            string company = comboBoxCompany.SelectedItem?.ToString();
            decimal fuelConsumption = numericUpDownFuelConsumption.Value;


            // Проверяем, что все поля заполнены
            if (string.IsNullOrEmpty(model) || string.IsNullOrEmpty(company))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }


            // Создаем объект самолета
            Airplane newAirplane = new Airplane(model, range, company, fuelConsumption);


            // Добавляем самолет в список
            airplanes.Add(newAirplane);


            // Обновляем ListBox
            UpdateListBox();


            // Очищаем поля формы
            comboBoxModel.SelectedIndex = -1;
            numericUpDownRange.Value = 0;
            comboBoxCompany.SelectedIndex = -1;
            numericUpDownFuelConsumption.Value = 0;
        }


        private void buttonSortByFuelConsumption_Click(object sender, EventArgs e)
        {
            SortAirplanesByFuelConsumption();
        }


        // Функция сортировки самолетов по среднему потреблению горючего
        private void SortAirplanesByFuelConsumption()
        {
            airplanes = airplanes.OrderBy(a => a.FuelConsumption).ToList();
            UpdateListBox();
        }


        // Функция обновления ListBox
        private void UpdateListBox()
        {
            listBoxAirplanes.Items.Clear();
            foreach (var airplane in airplanes)
            {
                listBoxAirplanes.Items.Add(airplane);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Заполняем ComboBox моделями самолетов
            comboBoxModel.Items.AddRange(new string[] { "Boeing 737", "Airbus A320", "Embraer 190" });


            // Заполняем ComboBox авиакомпаниями
            comboBoxCompany.Items.AddRange(new string[] { "Aeroflot", "S7 Airlines", "Utair" });
        }


        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}













   

