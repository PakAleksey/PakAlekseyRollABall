using System;
using UnityEngine;

namespace Geekbrains
{
    public sealed class ExampleLocalFunctions
    {
        private void GetAge()
        {
            var ageInput = "17";

            if (!IsAdult(ageInput))
            {
                Debug.Log("Регистрация разрешена только совершеннолетним");
            }
            
            bool IsAdult(string value) // Локальная функция
            {
                if (!Int32.TryParse(value, out var age)) throw new Exception(@"Возраст введен некорректно");
                if (age > 18)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
