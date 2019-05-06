using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryMethod
{
    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new Warming(temperature);
    }
}
