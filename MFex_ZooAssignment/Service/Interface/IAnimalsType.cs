using System;
using System.Collections.Generic;
using MFex_ZooAssignment.Service.Models;

namespace MFex_ZooAssignment.Service.Interface
{
    public interface IAnimalsType
    {
        ZooAnimal CalculateFoodIntakeForDay();
    }

}