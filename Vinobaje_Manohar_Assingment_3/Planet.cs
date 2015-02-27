using System;

namespace Assingment03Vinobaje_Manohar_Assingment_3
{
    abstract class Planet
    {
        double _diameter;
        double _mass;
        int _moonCount;
        string _name;
        double _orbitalPeriod;
        int _ringCount;
        double _rotationPeriod;

        public double Diameter
        {
            get //read-only
            {
                return this._diameter;
            }

        }

        public double Mass
        {
            get //read-only
            {
                return this._mass;
            }

        }

        public int moonCount
        {
            get //read-only
            {
                return this._moonCount;
            }

        }

        public string Name
        {
            get //read-only
            {
                return this._name;
            }

        }

        public double orbitalPeriod
        {
            get //read-only
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int ringCount
        {
            get //read-only
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double rotationPeriod
        {
            get //read-only
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }


        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        public override string ToString()
        {
            return this.Name + " is a planet, " + this.Diameter + " is it's diameter and " + this.Mass + " is it's mass.";
        }
    }
}
