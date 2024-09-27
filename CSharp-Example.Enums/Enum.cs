using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Example.Enums;

public enum Days
{
    SunDay = 1,
    MonDay,
    Thuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

/// <summary>
/// You should change the default date type of Enum (int) to everything (byte)
/// </summary>
public enum Gender : Byte
{
    Male,
    Female
}