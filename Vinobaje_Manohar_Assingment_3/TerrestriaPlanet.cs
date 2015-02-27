using System;


namespace Assingment03Vinobaje_Manohar_Assingment_3
{
    class TerrestriaPlanet : Planet, IHasMoons, IHabitable
    {
        private bool _oxygen;


        public TerrestriaPlanet(bool oxygen, string name, double diameter, double mass)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen; //local variable
        }

        public bool HasMoons()
        {
            return (moonCount > 0) ? true : false;
        }

        public bool Habitable()
        {
            return (_oxygen == true) ? true : false;
        }
    }
}
