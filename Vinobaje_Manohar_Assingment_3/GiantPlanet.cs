using System;


namespace Assingment03Vinobaje_Manohar_Assingment_3
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;

        public GiantPlanet(string type, string name, double diameter, double mass)
            : base(name, diameter, mass)
        {
            this._type = type;
        }

        public bool HasMoons()
        {
            return (moonCount > 0) ? true : false;
        }

        public bool HasRings()
        {
            return (ringCount > 0) ? true : false;

        }
    }
}
