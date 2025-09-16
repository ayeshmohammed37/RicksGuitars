using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksGuitars
{
    public class GuitarSpec
    {
        private Builder builder;
        private string model;
        private int numStrings;
        private Type type;
        private Wood backWood;
        private Wood topWood;

        public GuitarSpec(Builder builder, string model,int numstrings, Type type, Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            NumStrings = numstrings;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }

        public GuitarSpec(GuitarSpec guitarSpec)
        {
            Builder = guitarSpec.Builder;
            Model = guitarSpec.Model;
            NumStrings = guitarSpec.NumStrings; 
            Type = guitarSpec.Type;
            BackWood = guitarSpec.BackWood;
            TopWood = guitarSpec.TopWood;
        }

        public Builder Builder { get => builder; private set => builder = value; }
        public string Model { get => model; private set => model = value; }
        public Type Type { get => type; private set => type = value; }
        public Wood BackWood { get => backWood; private set => backWood = value; }
        public Wood TopWood { get => topWood; private set => topWood = value; }
        public int NumStrings { get => numStrings; private set => numStrings = value; }

        public override bool Equals(object? obj)
        {
            if (obj is GuitarSpec guitarSpec)
            {
                if (guitarSpec.Builder == Builder && guitarSpec.Model == Model && Type == guitarSpec.Type && guitarSpec.BackWood == BackWood && guitarSpec.TopWood == TopWood && guitarSpec.NumStrings == NumStrings)
                    return true;
            }
                return false;
        }

        public override string ToString()
        {
            return $"Builder: {Builder},\n\tModel: {Model}," +
                $"\n\tBackWood: {BackWood},\n\t" + $"TopWood: {TopWood}";
        }
    }
}
