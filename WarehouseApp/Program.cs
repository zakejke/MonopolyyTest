using System;
using System.Collections.Generic;

namespace WarehouseApp
{
    class Program
    {
        static void Main()
        {
            
            var pallets = DataGenerator.GeneratePallets(palletCount: 5, maxBoxesPerPallet: 10);

           
            WarehouseDisplay.DisplayPalletsByExpiration(pallets);

            
            WarehouseDisplay.DisplayTopPalletsByLongestBoxExpiration(pallets);

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
