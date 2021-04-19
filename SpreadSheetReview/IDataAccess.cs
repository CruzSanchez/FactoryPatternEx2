using System.Collections.Generic;

namespace FactoryPatternEx2ConsoleUI
{
    public interface IDataAccess
    {
        /// <summary>
        /// This method will create a static list of Products. The data will never change
        /// </summary>
        /// <returns>List<Product></returns>
        List<Product> LoadData();
        void SaveData();
    }
}