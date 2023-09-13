using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public interface IAnimal
    {
        public void DoCall();
        public void WhatDoUEat();
        public void Sleep();
    }

    public interface IMovementMethod
    {
        public void ToFly();
        public void ToSwim();
    }
}
