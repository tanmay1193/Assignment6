/*Assignment 6_Group 1
 * Group Members :  1. Oleksandr Rudavka
 *                  2. Jonathan Nagata
 *                  3. Niral Gandhi
 *                  4. Tanmay Teckchandani
 *                  5. Priya Tharuman
 *                  6. Krishna Kanhaiya
 *                  7. Lucas Currah
*/
using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

namespace KineticEnergy
{
    class ViewModel : ObservableObject
    {
        private string _mass;
        public string mass
        {
            get { return _mass; }
            set { _mass = value; OnPropertyChanged(); }
        }
        private string _velocity;
        public string velocity
        {
            get { return _velocity; }
            set { _velocity = value; OnPropertyChanged(); }
        }
        private string _kineticEnergy;
        public string kineticEnergy
        {
            get { return _kineticEnergy; }
            set { _kineticEnergy = value; OnPropertyChanged(); }
        }
        //method for calculating kinecticEnergy
        public void calcKineticEnergy()
        {
            try
            {
                double kineticEnergyF;
                double massF = double.Parse(_mass);
                double velocityF = double.Parse(_velocity);
                kineticEnergyF = Math.Pow(velocityF, 2) * massF * 0.5;
                kineticEnergy = kineticEnergyF.ToString() + " (J)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mass and velocity cannot be NULL", ex.ToString());
            }
        }
        //reset method
        public void reset()
        {
            mass = "";
            velocity = "";
            kineticEnergy = "";
        }
    }
}
